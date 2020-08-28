using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickController : MonoBehaviour
{




    void OnMouseEnter()
    {
        if (Input.GetMouseButton(0))
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;


            gameMaster.currentWord += GetComponent<TextMesh>().text;
            gameMaster.letterNum += 1;

            if (gameMaster.letterNum <= gameMaster.selectLetter.Capacity)
            {
                gameMaster.selectLetter[gameMaster.letterNum - 1] = GetComponent<TextMesh>().text;

            }

        }
    

    }

    //void OnMouseDown()
    //{
    //    Debug.Log("Mouse is down");

    //    RaycastHit hitInfo = new RaycastHit();
    //    bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
    //    if (hit)
    //    {
    //        Debug.Log("Hit " + hitInfo.transform.gameObject.name);
    //        if (hitInfo.transform.gameObject.tag == "letter")
    //        {
    //            Debug.Log("It's working!");
    //        }
    //        else
    //        {
    //            Debug.Log("nopz");
    //        }
    //    }
    //    else
    //    {
    //        Debug.Log("No hit");
    //    }
    //    //Debug.Log("Mouse is down");
    //}
}