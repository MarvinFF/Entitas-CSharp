//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Game2 {
    public partial interface IGame2PositionEntity {

        Game2.PositionComponent game2Position { get; }
        bool hasGame2Position { get; }

        void AddGame2Position(UnityEngine.Vector3Int newValue);
        void ReplaceGame2Position(UnityEngine.Vector3Int newValue);
        void RemoveGame2Position();
    }
}
