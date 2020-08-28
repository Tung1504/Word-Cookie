using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beingClicked : MonoBehaviour
{
    // Start is called before the first frame update
    void OnMouseEnter()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;


        gameMaster.currentWord += GetComponent<TextMesh>().text;
        gameMaster.letterNum += 1;

        if (gameMaster.letterNum <= gameMaster.selectLetter.Capacity)
        {
            gameMaster.selectLetter[gameMaster.letterNum - 1] = GetComponent<TextMesh>().text;

        }
    }


    void OnMouseUp()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = true;

        Debug.Log("Exit");
    }
}
