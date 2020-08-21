using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnClick()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
        gameMaster.currentWord += GetComponent<TextMesh>();
        gameMaster.letterNum = 0;
        gameMaster.selectLetter[gameMaster.letterNum - 1] = GetComponent<TextMesh>().text;
    }
}
