using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    [Header("Tile Rewards")] 
    public bool isReward;
    public bool doubleReward;
    public int tileGold;
    public int tileRemoveDice;
    public bool tileAddDice;
    public bool tileBustCount;
    
    [Header("Tile Special")]
    public bool isTileWater;
    public bool startTile;
    public bool tileWall;
    public int tileAheadBonus;

    [Header("Visual")]
    [SerializeField] private GameObject _highlight;
    [SerializeField] private GameObject _tileIconSingle;
    [SerializeField] private TextMeshPro _tileIconSingleText;
    [SerializeField] private GameObject _tileIconDouble;
    [SerializeField] private TextMeshPro  _tileIconDoubleText;
    [SerializeField] private List<Sprite> _possibleRewards;
    private void Start()
    {
        List<Sprite> rewardIcon = new List<Sprite>();
        if (isReward == true || doubleReward == true)
        {
            if (tileGold > 0)
            {
              rewardIcon.Add(_possibleRewards[0]);
              _tileIconSingleText.text = tileGold.ToString();
              _tileIconDoubleText.text = tileGold.ToString();
            }

            if (tileRemoveDice > 0 )
            {
                for (int i = 0; i < tileRemoveDice; i++)
                {
                    rewardIcon.Add(_possibleRewards[1]);
                }
            }

            if (tileAddDice == true)
            {
                rewardIcon.Add(_possibleRewards[2]);
            }

            if (tileBustCount == true)
            {
                rewardIcon.Add(_possibleRewards[3]);
            }
            
        }

        if (isReward)
        {
            _tileIconSingle.GetComponent<SpriteRenderer>().sprite = rewardIcon[0];
            _tileIconSingle.SetActive(true);
        }
        else if (doubleReward)
        {
            var i = 0;
            foreach (Transform child in _tileIconDouble.transform)
            {
                child.GetComponent<SpriteRenderer>().sprite = rewardIcon[i];
                i++;
            }
            _tileIconDouble.SetActive(true);
        }
    }
    
 
    void OnMouseEnter() {
        _highlight.SetActive(true);
    }
 
    void OnMouseExit()
    {
        _highlight.SetActive(false);
    }
}