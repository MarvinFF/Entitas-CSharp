//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public AnyMyEventClassListenerComponent anyMyEventClassListener { get { return (AnyMyEventClassListenerComponent)GetComponent(GameComponentsLookup.AnyMyEventClassListener); } }
    public bool hasAnyMyEventClassListener { get { return HasComponent(GameComponentsLookup.AnyMyEventClassListener); } }

    public void AddAnyMyEventClassListener(System.Collections.Generic.List<IAnyMyEventClassListener> newValue) {
        var index = GameComponentsLookup.AnyMyEventClassListener;
        var component = (AnyMyEventClassListenerComponent)CreateComponent(index, typeof(AnyMyEventClassListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceAnyMyEventClassListener(System.Collections.Generic.List<IAnyMyEventClassListener> newValue) {
        var index = GameComponentsLookup.AnyMyEventClassListener;
        var component = (AnyMyEventClassListenerComponent)CreateComponent(index, typeof(AnyMyEventClassListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveAnyMyEventClassListener() {
        RemoveComponent(GameComponentsLookup.AnyMyEventClassListener);
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
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherAnyMyEventClassListener;

    public static Entitas.IMatcher<GameEntity> AnyMyEventClassListener {
        get {
            if (_matcherAnyMyEventClassListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AnyMyEventClassListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAnyMyEventClassListener = matcher;
            }

            return _matcherAnyMyEventClassListener;
        }
    }
}
