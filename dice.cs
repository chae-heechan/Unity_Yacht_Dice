using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dice : MonoBehaviour
{
    public Image dice_top;

    public List<Sprite> eyes = new List<Sprite>(new Sprite[6]);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void RollDice()
    {
        int rannum = Random.Range(0, 5);

        dice_top.sprite = eyes[rannum];
    }

    public void MoveMyList()
    {

    }
}
