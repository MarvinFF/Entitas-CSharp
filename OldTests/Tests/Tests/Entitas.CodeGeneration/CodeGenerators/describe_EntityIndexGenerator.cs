﻿using DesperateDevs.CodeGeneration;
using Entitas.CodeGeneration.Plugins;
using NSpec;
using Shouldly;

class describe_EntityIndexGenerator : nspec {

    void when_generating() {

        it["doesn't generate file when no indices specified"] = () => {
            var generator = new EntityIndexGenerator();
            var files = generator.Generate(new CodeGeneratorData[0]);
            files.Length.ShouldBe(0);
        };
    }
}
