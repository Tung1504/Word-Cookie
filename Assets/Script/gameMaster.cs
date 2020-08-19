using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameMaster : MonoBehaviour
{
    public static string currentWord;
    public Transform spelledWord;

    public Transform letter1;
    public Transform letter2;
    public Transform letter3;

    public Transform bttLetter1;
    public Transform bttLetter2;
    public Transform bttLetter3;
    public Transform bttLetter4;

    public static List<string> availLetter = new List<string>() { "W", "I", "N", "E" };

    public KeyCode RMB;
    public int wordLen;
    public string word3L = "WIN";
    public static List<string> selectLetter = new List<string>() {"","",""};
    public static int letterNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        bttLetter1.GetComponent<TextMesh>().text = availLetter[0];
        bttLetter2.GetComponent<TextMesh>().text = availLetter[1];
        bttLetter3.GetComponent<TextMesh>().text = availLetter[2];
        bttLetter4.GetComponent<TextMesh>().text = availLetter[3];
    }

    // Update is called once per frame
    void Update()
    {
        spelledWord.GetComponent<TextMesh>().text = currentWord;
        if (Input.GetKeyDown(RMB))
        {
            wordLen = currentWord.Length;
            

            if (wordLen == 3)
            {
             
                if (currentWord == word3L)
                {
                   

                    letter1.GetComponent<TextMesh>().text = selectLetter[0];
                    letter2.GetComponent<TextMesh>().text = selectLetter[1];
                    letter3.GetComponent<TextMesh>().text = selectLetter[2];

                }
                else
                {
                    Debug.Log("Wrong word");
                }
            }
            else if (wordLen > 3 && array.Length)
            {
                
                Debug.Log("Out of length");
            }
        }
    }
}
