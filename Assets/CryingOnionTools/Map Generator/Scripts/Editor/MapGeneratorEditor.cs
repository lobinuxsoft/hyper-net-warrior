using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MapGenerator))]
public class MapGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        MapGenerator map = (MapGenerator)target;

        if(DrawDefaultInspector())
            map.GenerateMap();

        if(GUILayout.Button("Generate Map"))
            map.GenerateMap();
    }
}
