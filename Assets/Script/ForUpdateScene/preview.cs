using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class preview : MonoBehaviour
{
    public GameObject content;
    public Transform textGrid;
    public string word;


    public static preview instance;

    CanvasGroup canvasGroup;
    


    private void Start()
    {
        canvasGroup = content.GetComponent<CanvasGroup>();
    }
    void SetActive(bool isActive)
    {
        content.SetActive(isActive && textGrid.childCount > 0);
    }

    void SetIndexes(List<int> indexes)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = indexes.Count; i >= 0; i++)
        {
            sb.Append(word[i]);
            Debug.Log("Append Working");
        }

        foreach (Transform item in textGrid)
        {
            Destroy(item.gameObject);
            Debug.Log("Destroy Working");
        }

    }   
    

    void ClearText()
    {
        foreach (Transform item in textGrid)
        {
            Destroy(item.gameObject);
            Debug.Log("ClearText Working");
        }    
    }


    public string GetText()
    {
        string s = "";
        foreach (Transform item in textGrid)
        {
            s += item.GetComponent<TextMesh>().text;
            Debug.Log("Working");

        }
        return s;
        
    }    
}
