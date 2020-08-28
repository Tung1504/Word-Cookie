using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hintButton : MonoBehaviour
{
    public Transform letter;
    List<string> abcd = new List<string>();
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        
        //Convert to array
        foreach (string ans in gameMaster.answers)
        {
            
            //Debug.Log(ans);
            char[] chararr = ans.ToCharArray();
            
            //debug.log("working");
            foreach (char ch in chararr)
            {
                String cString = ch.ToString();
                abcd.Add(cString);
                
                //Debug.Log(ch);
                //foreach (string c in abcd)
                //{
                //    Debug.Log("In String List:" + c);
                //}    
            }
            
        }
        letter.GetComponent<TextMesh>().text = abcd[0];
    }
}
