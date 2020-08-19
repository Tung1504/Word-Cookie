using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickController : MonoBehaviour
{
   

    void OnMouseDown()
    {
        
        gameMaster.currentWord += GetComponent<TextMesh>().text;
        gameMaster.letterNum += 1;
        gameMaster.selectLetter[gameMaster.letterNum] = GetComponent<TextMesh>().text;
    }
}