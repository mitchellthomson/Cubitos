using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Player Info")] 
    public GameController gc;
    public bool isStartingPlayer;
    public int diceAmount = 9;
    public int bustCount;
    [Space(10)] [Header("Dice Info")] 
    public int rollCount;
    
    public List<GameObject> drawPile = new();
    public List<DiceRoll> rollPile = new();
    public List<DiceRoll> activePile = new();
    public List<GameObject> discardPile = new();
    
    [Space(10)] [Header("Run Phase")] 
    private bool _busted;
    public int playerMovement;
    public int playerGold;
    public int playerSilver;

    public void PlayerRoll()
    {
        if (_busted == false && rollCount<3 && rollPile.Count > 0)
        {
            StartCoroutine(PlayerCurRoll());
        }
        else
        {
            if (_busted == true)
            {
                print("Busted ass");
            }
            else
            {
                print("out of rolls idiot");
            }
        }
    }
    private IEnumerator PlayerCurRoll()
    {
        int oldCount = activePile.Count;
        
        yield return gc.RollPhase(this);
        
        foreach (DiceRoll dice in rollPile.ToList())
        {
            if (dice.result != DiceObject.DiceValues.Blank)
            {
                activePile.Add(dice);
                rollPile.Remove(dice);
            }
        }
        if (rollCount > 0)
        {
            var newCount = activePile.Count;
            if (newCount <= oldCount)
            {
                print("Busted Right now");
                bustCount++;
                _busted = true;
            }
        }
        rollCount++;
    }
}
