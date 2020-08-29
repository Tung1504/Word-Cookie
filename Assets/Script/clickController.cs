using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickController : MonoBehaviour
{

    //private GameObject letter;
    //public GameObject line;

    void OnMouseEnter()
    {
        if (Input.GetMouseButton(0))
        {
            //Instantiate(line);
            transform.localScale = new Vector3(1.5f, 1.5f, 0);

            gameObject.GetComponent<BoxCollider2D>().enabled = false;


            gameMaster.currentWord += GetComponent<TextMesh>().text;
            gameMaster.letterNum += 1;

            if (gameMaster.letterNum <= gameMaster.selectLetter.Capacity)
            {
                gameMaster.selectLetter[gameMaster.letterNum - 1] = GetComponent<TextMesh>().text;

            }
        }
    }

    

}
    

   
