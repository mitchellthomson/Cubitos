using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New Dice", menuName = "Dice")]
public class DiceObject : ScriptableObject
{
    public List<Sprite> diceFacesSprite = new List<Sprite>();
    public enum DiceColor{Blue,Brown,DarkGrey,Green,LightGrey,Orange,Purple,Red,Starting,White,Yellow}
    public enum DiceValues{Blank,Symbol,Power,Foot,Gold,GoldTwo,GoldThree,Silver,Null};
    
    public DiceColor diceColor;
    public List<DiceValues> diceValues = new List<DiceValues>();

}
