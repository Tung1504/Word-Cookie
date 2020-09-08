using System.Collections;
using System.Collections.Generic;

using UnityEditor.UI;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class gameMaster : MonoBehaviour
{


    public static string currentWord;
    public GameObject spelledWord;

    public levelData levelData;

    


    public GameObject wrong;
    public GameObject right;

    public GameObject letter;



    public Transform letterAns;

    

    
    public static List<string> answers = new List<string>()   ;
    public KeyCode RMB;
    public static int wordLen;

    
    public static List<string> selectLetter = new List<string>() ;
    public static int letterNum = 0;


    List<char> let = new List<char>();


    // Start is called before the first frame update
    void Start()
    {
        string[] answerC = levelData.answer.Split(',');
        
            foreach (string c in answerC)
            {
                answers.Add(c);
            
            
            }


        //for (var i = 0; i < )

                
        

     
            
        
        //foreach (char b in let)
        //{
        //    Debug.Log(b);
        //}    

        //for (int i = 0; i < let.Count; i++)
        //{
        //    Instantiate(letterAns, new Vector3(0, i * 0.5f, 0), letter.transform.rotation);
        //}    


        
        //string[] chars = answers.ToArray();
 
        
        


        //for (int i = 0; i < chars.Length; i ++)
        //{
        //    foreach (string d in chars)
        //    {
        //        Debug.Log(d);
             
        //        letterAns.GetComponent<TextMesh>().text = chars[i];
        //    }
        //    Instantiate(letterAns, new Vector3(0, i * 0.5f, 0), letter.transform.rotation);
        //}    
        

        //foreach (string d in chars)
        //{
        //    for (int i = 0; i < d.Length; i++)
        //    {   
                

        //        Instantiate(letterAns, new Vector3(0, i * 0.5f, 0.5f), letter.transform.rotation);
        //    }    
        //}    


        
        
       
        
    }


    
    public void Create()
    {
        for (int i = 0; i < answers.Count; i++)
        {
           foreach (string a in answers)
           {
               letter.GetComponent<TextMesh>().text = answers[i];

           }
           Instantiate(letter,new Vector3(0, i * 0.5f, 0), letter.transform.rotation);
        }
    }    


    public void Answer()
    {
        //List<>





    }





        // Update is called once per frame
    void Update()
    {
        


            spelledWord.GetComponent<TextMesh>().text = currentWord;

            if (Input.GetKeyDown(RMB))
            {
                wordLen = currentWord.Length;


                if (answers.Contains(currentWord))
                {
                    for (int i = 0; i < selectLetter.Count; i++)
                    {
                        
                        letterAns.GetComponent<TextMesh>().text = selectLetter[i];
                        
                        Instantiate(letterAns, new Vector3(i * 0.5f, 0, 0), letter.transform.rotation);


                    }
                    Instantiate(right);
                        //letter1.GetComponent<TextMesh>().text = selectLetter[0];
                        //letter2.GetComponent<TextMesh>().text = selectLetter[1];
                        //letter3.GetComponent<TextMesh>().text = selectLetter[2];
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

           
    }
}
