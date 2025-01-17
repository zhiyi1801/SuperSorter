using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObject/Rules/ColorRule")]
public class ColorRule : Rule
{
    public enum Color
    {
        [InspectorName("Red")]
        RED,
        [InspectorName("Blue")]
        BLUE,
        [InspectorName("Green")]
        GREEN
    }

    [SerializeField]
    private List<Color> AllowedColors = new List<Color>();

    public override bool Score(Scoreable scoreable)
    {
        return AllowedColors.Contains(scoreable.Color);
    }
}
