using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // ReSharper disable Unity.PerformanceAnalysis
    
    public IEnumerator RollPhase(Player player)
    {
        var rollPile = player.rollPile;
        
        foreach (DiceRoll dice in rollPile)
        {
            StartCoroutine(dice.RollTheDice());
        }
        
        yield return new WaitUntil(() => rollPile[rollPile.Count-1].result != DiceObject.DiceValues.Null);
    }
    
}
