using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineBlock : MonoBehaviour
{
    public static lineBlock instance = null;
    // Start is called before the first frame update
    List<string> cell = new List<string>();

    public static List<string> answers = new List<string>();

    public levelData levelData;

    public GameObject letter;


    void Awake()
    {
        instance = this;        
    }

    void Start()
    {
        string[] answerC = levelData.answer.Split(',');
        //for (int i = 0; i < 1; i++)
        //{
        foreach (string c in answerC)
        {
            answers.Add(c);
            
        }
        
    }


    void Update()
    {
        for (int i = 0; i < answers.Count; i++)
        {
            letter.transform.localPosition = new Vector3(0, 623, 0);
        }    
    }


}
