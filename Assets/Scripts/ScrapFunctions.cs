using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrapFunctions : MonoBehaviour
{
    //From Gamecontroller to roll all dice in player pile
    
    // ReSharper disable Unity.PerformanceAnalysis
    // public IEnumerator RollPhase(Player player)
    // {
    //     var rollPile = player.rollPile;
    //     for (int i = 0;i < rollPile.Count;i ++)
    //     {
    //         yield return rollPile[i].GetComponent<DiceRoll>().RollTheDice();
    //         var value = rollPile[i].GetComponent<DiceRoll>().rolled;
    //         print(value);
    //         if (value != DiceObject.DiceValues.Blank)
    //         {
    //             player.activePile.Add(rollPile[i]);
    //             player.rollPile.Remove(rollPile[i]);
    //         }
    //     }
    // }
}
