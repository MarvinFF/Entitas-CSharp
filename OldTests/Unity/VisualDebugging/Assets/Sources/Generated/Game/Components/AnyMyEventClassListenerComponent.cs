//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddAnyMyEventClassListener(IAnyMyEventClassListener value) {
        var listeners = hasAnyMyEventClassListener
            ? anyMyEventClassListener.value
            : new System.Collections.Generic.List<IAnyMyEventClassListener>();
        listeners.Add(value);
        ReplaceAnyMyEventClassListener(listeners);
    }

    public void RemoveAnyMyEventClassListener(IAnyMyEventClassListener value, bool removeComponentWhenEmpty = true) {
        var listeners = anyMyEventClassListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveAnyMyEventClassListener();
        } else {
            ReplaceAnyMyEventClassListener(listeners);
        }
    }
}
