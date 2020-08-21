using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonReset : MonoBehaviour
{
    // Start is called before the first frame update


    void OnMouseDown()
    {
        SceneManager.LoadScene("Basic");

        //Debug.Log("SelectLetterCapacity: " + gameMaster.selectLetter.Capacity);


        //Debug.Log("LetterNum: " + gameMaster.letterNum);
        gameMaster.letterNum = 0;
        gameMaster.currentWord = string.Empty;
        gameMaster.selectLetter.Clear();

        List<string> abc = new List<string>();
        abc.Add("");
        abc.Add("");
        abc.Add("");
        abc.Add("");

        gameMaster.selectLetter.AddRange(abc);
        //foreach (string item in gameMaster.selectLetter)
        //{
        //    Debug.Log(item);
        //}
        //Debug.Log("CurrentWord: " + gameMaster.currentWord);
        //Debug.Log("Ờ oke");
    }


    
}
