using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickController : MonoBehaviour
{
   

    void Start()
    {

    }

    void OnMouseDown()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;


        gameMaster.currentWord += GetComponent<TextMesh>().text;
        gameMaster.letterNum += 1;

        if (gameMaster.letterNum <= gameMaster.selectLetter.Capacity)
        {
            if (gameMaster.selectLetter.Contains(GetComponent<TextMesh>().text))
            //{
            //    gameObject.GetComponent<BoxCollider2D>().enabled = false;
            //}
            //else
            //{
                //gameObject.GetComponent<BoxCollider2D>().enabled = true;
                gameMaster.selectLetter[gameMaster.letterNum - 1] = GetComponent<TextMesh>().text;
            //}
        }




    }

      
}