using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class clickController : MonoBehaviour
{

    //private GameObject letter;
    //public GameObject line;


    

    Vector3 currentPosition;
    

    void OnMouseEnter()
    {
        if (Input.GetMouseButton(0))
        {

            currentPosition = transform.position;


            //Instantiate(line);
            transform.localScale = new Vector3(1.5f,1.5f, 0);

            gameObject.GetComponent<BoxCollider2D>().enabled = false;


            gameMaster.currentWord += GetComponent<TextMesh>().text;
            gameMaster.letterNum += 1;

            if (gameMaster.letterNum <= gameMaster.selectLetter.Capacity)
            {
                gameMaster.selectLetter[gameMaster.letterNum - 1] = GetComponent<TextMesh>().text;

            }   
        }


        //else /*if ()*/
        //{
        //    gameObject.GetComponent<BoxCollider2D>().enabled = true;
        //    transform.localScale = new Vector3(-1.5f, -1.5f, 0);
        //}    
    }



    



}
    

   
