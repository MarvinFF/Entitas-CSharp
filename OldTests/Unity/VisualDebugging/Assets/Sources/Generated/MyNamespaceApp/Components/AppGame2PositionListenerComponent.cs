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

        public Game2PositionListenerComponent game2PositionListener { get { return (Game2PositionListenerComponent)GetComponent(My.Namespace.AppComponentsLookup.Game2PositionListener); } }
        public bool hasGame2PositionListener { get { return HasComponent(My.Namespace.AppComponentsLookup.Game2PositionListener); } }

        public void AddGame2PositionListener(System.Collections.Generic.List<IGame2PositionListener> newValue) {
            var index = My.Namespace.AppComponentsLookup.Game2PositionListener;
            var component = (Game2PositionListenerComponent)CreateComponent(index, typeof(Game2PositionListenerComponent));
            component.value = newValue;
            AddComponent(index, component);
        }

        public void ReplaceGame2PositionListener(System.Collections.Generic.List<IGame2PositionListener> newValue) {
            var index = My.Namespace.AppComponentsLookup.Game2PositionListener;
            var component = (Game2PositionListenerComponent)CreateComponent(index, typeof(Game2PositionListenerComponent));
            component.value = newValue;
            ReplaceComponent(index, component);
        }

        public void RemoveGame2PositionListener() {
            RemoveComponent(My.Namespace.AppComponentsLookup.Game2PositionListener);
        }
    }
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

        static Entitas.IMatcher<AppEntity> _matcherGame2PositionListener;

        public static Entitas.IMatcher<AppEntity> Game2PositionListener {
            get {
                if (_matcherGame2PositionListener == null) {
                    var matcher = (Entitas.Matcher<AppEntity>)Entitas.Matcher<AppEntity>.AllOf(My.Namespace.AppComponentsLookup.Game2PositionListener);
                    matcher.componentNames = My.Namespace.AppComponentsLookup.componentNames;
                    _matcherGame2PositionListener = matcher;
                }

                return _matcherGame2PositionListener;
            }
        }
    }
}
