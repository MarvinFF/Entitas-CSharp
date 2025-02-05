//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace YourNamespace {
    public partial class AppEntity {

        public Game1.PositionComponent game1Position { get { return (Game1.PositionComponent)GetComponent(YourNamespace.AppComponentsLookup.Game1Position); } }
        public bool hasGame1Position { get { return HasComponent(YourNamespace.AppComponentsLookup.Game1Position); } }

        public void AddGame1Position(UnityEngine.Vector3Int newValue) {
            var index = YourNamespace.AppComponentsLookup.Game1Position;
            var component = (Game1.PositionComponent)CreateComponent(index, typeof(Game1.PositionComponent));
            component.Value = newValue;
            AddComponent(index, component);
        }

        public void ReplaceGame1Position(UnityEngine.Vector3Int newValue) {
            var index = YourNamespace.AppComponentsLookup.Game1Position;
            var component = (Game1.PositionComponent)CreateComponent(index, typeof(Game1.PositionComponent));
            component.Value = newValue;
            ReplaceComponent(index, component);
        }

        public void RemoveGame1Position() {
            RemoveComponent(YourNamespace.AppComponentsLookup.Game1Position);
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace YourNamespace {
    public partial class AppEntity : Game1.IGame1PositionEntity { }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace YourNamespace {
    public sealed partial class AppMatcher {

        static Entitas.IMatcher<AppEntity> _matcherGame1Position;

        public static Entitas.IMatcher<AppEntity> Game1Position {
            get {
                if (_matcherGame1Position == null) {
                    var matcher = (Entitas.Matcher<AppEntity>)Entitas.Matcher<AppEntity>.AllOf(YourNamespace.AppComponentsLookup.Game1Position);
                    matcher.componentNames = YourNamespace.AppComponentsLookup.componentNames;
                    _matcherGame1Position = matcher;
                }

                return _matcherGame1Position;
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventListenerComponentGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace YourNamespace {
    [Entitas.CodeGeneration.Attributes.DontGenerate(false)]
    public sealed class Game1PositionListenerComponent : Entitas.IComponent {
        public System.Collections.Generic.List<IGame1PositionListener> value;
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventListenertInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace YourNamespace {
    public interface IGame1PositionListener {
        void OnGame1Position(AppEntity entity, UnityEngine.Vector3Int value);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace YourNamespace {
    public sealed class Game1PositionEventSystem : Entitas.ReactiveSystem<YourNamespace.AppEntity> {

        readonly System.Collections.Generic.List<IGame1PositionListener> _listenerBuffer;

        public Game1PositionEventSystem(Contexts contexts) : base(contexts.yourNamespaceApp) {
            _listenerBuffer = new System.Collections.Generic.List<IGame1PositionListener>();
        }

        protected override Entitas.ICollector<YourNamespace.AppEntity> GetTrigger(Entitas.IContext<YourNamespace.AppEntity> context) {
            return Entitas.CollectorContextExtension.CreateCollector(
                context, Entitas.TriggerOnEventMatcherExtension.Added(YourNamespace.AppMatcher.Game1Position)
            );
        }

        protected override bool Filter(YourNamespace.AppEntity entity) {
            return entity.hasGame1Position && entity.hasGame1PositionListener;
        }

        protected override void Execute(System.Collections.Generic.List<YourNamespace.AppEntity> entities) {
            foreach (var e in entities) {
                var component = e.game1Position;
                _listenerBuffer.Clear();
                _listenerBuffer.AddRange(e.game1PositionListener.value);
                foreach (var listener in _listenerBuffer) {
                    listener.OnGame1Position(e, component.Value);
                }
            }
        }
    }
}
