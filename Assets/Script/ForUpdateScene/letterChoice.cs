using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class letterChoice : MonoBehaviour
{
    public levelData levelData;

    public Transform letter1;
    public Transform letter2;
    public Transform letter3;
    public Transform letter4;


    public List<char> list = new List<char>();
    private void Start()
    {
        foreach (char a in levelData.letter)
        {
            list.Add(a);
        }
        Debug.Log(list.Count);
    }

    private void Update()
    {
        //if (Input.GetKeyDown("a"))
        //{
           

            

            //for (var i = 0; i < list.Count; i++)
            //{
                letter1.GetComponent<TextMesh>().text = list[0].ToString();
                letter2.GetComponent<TextMesh>().text = list[1].ToString();
                letter3.GetComponent<TextMesh>().text = list[2].ToString();
                letter4.GetComponent<TextMesh>().text = list[3].ToString();
            //}
        //}
    }

}
