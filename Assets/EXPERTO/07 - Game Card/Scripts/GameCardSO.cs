using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameCardType 
{
    None,
    Spellcaster,
    Dragon,
    Effect
}

[CreateAssetMenu(fileName = "New Game Card", menuName = "Scriptable Objects/Game Card", order = 1)]
public class GameCardSO : ScriptableObject
{
    [Header("Information")]
    public string title;
    [Range(0,12)] public int level;
    public GameCardType[] types;
    [TextArea] public string description;

    [Header("Card")]
    public Texture texture;
    public Color color;
    public bool isHolographic;

    [Header("Stats")]
    public int statAttack;
    public int statDefense;

    private string _levelString = "<sprite index=0>";

    public string GetLevel() 
    {
        if (level == 0)
        {
            return "";
        }
        else 
        {
            string tempLevel = _levelString;

            for (int i = 1; i < level; i++)
            {
                tempLevel += $" {_levelString}";
            }
            return tempLevel;
        }
    }

    public string GetTypes()
    {
        string tempType = types[0].ToString();
        
        if (types.Length > 1) 
        {
            for (int i = 1; i < types.Length; i++)
            {
                tempType += $"/{types[i]}";
            }
        }
        return tempType;
    }
}
