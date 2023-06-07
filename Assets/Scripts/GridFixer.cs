using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
[ExecuteInEditMode]
public class GridFixer : MonoBehaviour
{
    [SerializeField] private GameObject tilePrefab;
    public List<Vector3> posList = new();
    public List<Tile> tiles = new();
    public Transform parent;
    public Color colorOne;
    public Color colorTwo;
    void Awake()
    {
        var temp = 0;
        foreach (Transform child in transform)
        {
            child.position = posList[temp];
            temp++;
            child.name = ("Tile " + temp);
            if ((temp+1) % 2 == 0)
            {
                child.GetComponent<SpriteRenderer>().color = colorTwo;
            }
            else
            {
                child.GetComponent<SpriteRenderer>().color = colorOne;
            }
        }
    }

    
}
