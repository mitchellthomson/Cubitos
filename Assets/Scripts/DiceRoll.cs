using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DiceRoll : MonoBehaviour {
    
    private List<Sprite> _diceSides = new List<Sprite>();
    private SpriteRenderer _rend;
    [SerializeField] private DiceObject diceType;
    private bool _hasRolled;
    public DiceObject.DiceValues result;
    

    // Use this for initialization
	private void Start () 
    {
        _rend = GetComponent<SpriteRenderer>();
        _diceSides = diceType.diceFacesSprite;
    }
    public IEnumerator RollTheDice()
    {
        result = DiceObject.DiceValues.Null;
        int randomDiceSide = 0;
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 6);
            _rend.sprite = _diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }
        
        result = diceType.diceValues[randomDiceSide];
        
        
    }
    
}
