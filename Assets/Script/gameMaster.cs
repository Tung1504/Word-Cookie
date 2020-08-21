using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
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

    private List<string> availLetter = new List<string>() { "W", "I", "N", "E" };

    public KeyCode RMB;
    public static int wordLen;

    public static string word3L = "WIN";
    public static List<string> selectLetter = new List<string>() { "", "", "", "" } ;
    public static int letterNum = 0;
    

    //private List<string> line = new List<string>();


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
                    foreach (string item in selectLetter)
                    {
                        Debug.Log(item);
                    }
                    letter1.GetComponent<TextMesh>().text = selectLetter[0];
                    letter2.GetComponent<TextMesh>().text = selectLetter[1];
                    letter3.GetComponent<TextMesh>().text = selectLetter[2];
                    
                }
                else
                {
                    foreach (string item in selectLetter)
                    {
                        Debug.Log(item);
                    }
                    letterNum = 0;
                    currentWord = string.Empty;  
                    Debug.Log("Wrong word");
                    
                    
                }
            }
            else if (wordLen != 3)
            {
                letterNum = 0;
                currentWord = string.Empty;
                Debug.Log("Maximum letters is 3");
            }
        }

        //if (Input.GetKeyDown("g"))
        //{
            
        //    Debug.Log(selectLetter.Capacity);
            
            
        //    Debug.Log(letterNum);
        //    letterNum = 0;
        //    currentWord = string.Empty;
        //    selectLetter.Clear();
            
        //    List<string> abc = new List<string>();
        //    abc.Add("");
        //    abc.Add("");
        //    abc.Add("");
        //    abc.Add("");

        //    selectLetter.AddRange(abc);
        //    foreach (string item in selectLetter)
        //    {
        //        Debug.Log(item);
        //    }
        //    Debug.Log(currentWord);
        //    Debug.Log("Ờ oke");
            
        //}
    }
}
