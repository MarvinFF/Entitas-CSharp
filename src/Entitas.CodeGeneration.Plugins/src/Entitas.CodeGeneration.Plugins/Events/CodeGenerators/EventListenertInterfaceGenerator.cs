﻿using System.IO;
using System.Linq;
using DesperateDevs.CodeGeneration;
using DesperateDevs.Utils;

namespace Entitas.CodeGeneration.Plugins {

    public class EventListenertInterfaceGenerator : AbstractGenerator {

        public override string name { get { return "Event (Listener Interface)"; } }

        const string TEMPLATE =
            @"public interface I${EventListener} {
    void On${EventComponentName}${EventType}(${ContextName}Entity entity${methodParameters});
}
";

        public override CodeGenFile[] Generate(CodeGeneratorData[] data) {
            return data
                .OfType<ComponentData>()
                .Where(d => d.IsEvent())
                .SelectMany(generate)
                .ToArray();
        }

        CodeGenFile[] generate(ComponentData data) {
            return data.GetContextNames()
                .SelectMany(contextName => generate(contextName, data))
                .ToArray();
        }

        CodeGenFile[] generate(string contextName, ComponentData data) {
            return data.GetEventData()
                .Select(eventData => {
                    var memberData = data.GetMemberData();
                    if (memberData.Length == 0) {
                        memberData = new[] { new MemberData("bool", data.PrefixedComponentName()) };
                    }

                    var fileContent = TEMPLATE
                        .Replace("${methodParameters}", data.GetEventMethodArgs(eventData, ", " + memberData.GetMethodParameters(false)))
                        .Replace(data, contextName, eventData);

                    var (ns, typeName) = contextName.ExtractNamespace();
                    return new CodeGenFile(
                        contextName.RemoveDots() + Path.DirectorySeparatorChar +
                        "Components" + Path.DirectorySeparatorChar +
                        data.ComponentNameWithContext(typeName).AddComponentSuffix() + ".cs",
                        fileContent.WrapInNamespace(ns),
                        GetType().FullName
                    );
                }).ToArray();
        }
    }
}
