using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvas : MonoBehaviour
{
    public List<Button> MyList = new List<Button>(new Button[5]);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SortMyList()
    {
        if (MyList[0])
        {
            MyList[0].Select();
        }
    }
}
