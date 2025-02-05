//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace My.Namespace {
    public partial class AppContext {

        public AppEntity game1AppNameEntity { get { return GetGroup(AppMatcher.Game1AppName).GetSingleEntity(); } }
        public Game1.AppNameComponent game1AppName { get { return game1AppNameEntity.game1AppName; } }
        public bool hasGame1AppName { get { return game1AppNameEntity != null; } }

        public AppEntity SetGame1AppName(string newValue) {
            if (hasGame1AppName) {
                throw new Entitas.EntitasException("Could not set Game1AppName!\n" + this + " already has an entity with Game1.AppNameComponent!",
                    "You should check if the context already has a game1AppNameEntity before setting it or use context.ReplaceGame1AppName().");
            }
            var entity = CreateEntity();
            entity.AddGame1AppName(newValue);
            return entity;
        }

        public void ReplaceGame1AppName(string newValue) {
            var entity = game1AppNameEntity;
            if (entity == null) {
                entity = SetGame1AppName(newValue);
            } else {
                entity.ReplaceGame1AppName(newValue);
            }
        }

        public void RemoveGame1AppName() {
            game1AppNameEntity.Destroy();
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace My.Namespace {
    public partial class AppEntity {

        public Game1.AppNameComponent game1AppName { get { return (Game1.AppNameComponent)GetComponent(My.Namespace.AppComponentsLookup.Game1AppName); } }
        public bool hasGame1AppName { get { return HasComponent(My.Namespace.AppComponentsLookup.Game1AppName); } }

        public void AddGame1AppName(string newValue) {
            var index = My.Namespace.AppComponentsLookup.Game1AppName;
            var component = (Game1.AppNameComponent)CreateComponent(index, typeof(Game1.AppNameComponent));
            component.Value = newValue;
            AddComponent(index, component);
        }

        public void ReplaceGame1AppName(string newValue) {
            var index = My.Namespace.AppComponentsLookup.Game1AppName;
            var component = (Game1.AppNameComponent)CreateComponent(index, typeof(Game1.AppNameComponent));
            component.Value = newValue;
            ReplaceComponent(index, component);
        }

        public void RemoveGame1AppName() {
            RemoveComponent(My.Namespace.AppComponentsLookup.Game1AppName);
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
namespace My.Namespace {
    public partial class AppEntity : Game1.IGame1AppNameEntity { }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace My.Namespace {
    public sealed partial class AppMatcher {

        static Entitas.IMatcher<AppEntity> _matcherGame1AppName;

        public static Entitas.IMatcher<AppEntity> Game1AppName {
            get {
                if (_matcherGame1AppName == null) {
                    var matcher = (Entitas.Matcher<AppEntity>)Entitas.Matcher<AppEntity>.AllOf(My.Namespace.AppComponentsLookup.Game1AppName);
                    matcher.componentNames = My.Namespace.AppComponentsLookup.componentNames;
                    _matcherGame1AppName = matcher;
                }

                return _matcherGame1AppName;
            }
        }
    }
}
