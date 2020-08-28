using System.Collections;
using System.Collections.Generic;

using UnityEditor.UI;
using UnityEngine;


public class gameMaster : MonoBehaviour
{


    public static string currentWord;
    public Transform spelledWord;

    public levelData levelData;

    public Transform letter1;
    public Transform letter2;
    public Transform letter3;


    public GameObject wrong;
    public GameObject right;


    //public Transform bttLetter1;
    //public Transform bttLetter2;
    //public Transform bttLetter3;
    //public Transform bttLetter4;

    //private List<string> availLetter = new List<string>() { "W", "I", "N", "E" };
    public static List<string> answers = new List<string>() /*{ "WIN"/*, "NEW"*/  ;
    public KeyCode RMB;
    public static int wordLen;

    //public static string word3L = "WIN";
    public static List<string> selectLetter = new List<string>() /*{ "", "", "", "" }*/ ;
    public static int letterNum = 0;


    //private List<string> line = new List<string>();


    // Start is called before the first frame update
    void Start()
    {
        string[] answerC = levelData.answer.Split(',');
        //for (int i = 0; i < 1; i++)
        //{
            foreach (string c in answerC)
            {
                answers.Add(c);
            }
        //}        
        foreach (string a in answers)        
        {        
            Debug.Log(a);            
        }
        
            //bttLetter1.GetComponent<TextMesh>().text = availLetter[0];
            //bttLetter2.GetComponent<TextMesh>().text = availLetter[1];
            //bttLetter3.GetComponent<TextMesh>().text = availLetter[2];
            //bttLetter4.GetComponent<TextMesh>().text = availLetter[3];
        for (int y = 0; y < 5; y++)
        {
            selectLetter.Add("");
        }
            Debug.Log("S: " + selectLetter.Count);
        
    }
        // Update is called once per frame
        void Update()
        {
            spelledWord.GetComponent<TextMesh>().text = currentWord;

            if (Input.GetKeyDown(RMB))
            {
                wordLen = currentWord.Length;


                //if (wordLen <= 3)
                //{

                    if (answers.Contains(currentWord))
                    {

                        Instantiate(right);
                        letter1.GetComponent<TextMesh>().text = selectLetter[0];
                        letter2.GetComponent<TextMesh>().text = selectLetter[1];
                        letter3.GetComponent<TextMesh>().text = selectLetter[2];
                        Debug.Log("Correct Word. Press Restart to play again.");

                    }

                    else /*if (currentWord != item)*/
                    {
                        Instantiate(wrong);
                        //letterNum = 0;
                        //currentWord = string.Empty;  
                        Debug.Log("Wrong word. Press Restart to try again.");


                    }

                //}
                //else if (wordLen > 3)
                //{

                //    //letterNum = 0;
                //    //currentWord = string.Empty;
                //    Debug.Log("Maximum letters is 3. Press Restart to try again.");
                //}
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
