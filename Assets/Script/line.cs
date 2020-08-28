using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour
{
    private LineRenderer dline;
    private bool isMousePressed;
    private List<Vector3> pointsList;
    public GameObject lineParticle;

    //bool isDragging;
    public letterChoice letterChoice;

    void Awake()
    {

        dline = gameObject.GetComponent<LineRenderer>();
        if (dline == null)
        {
            dline = gameObject.AddComponent<LineRenderer>();
            //line.material = new Material(Shader.Find("Particles/Additive"));
        }
        dline.SetVertexCount(0);
        dline.SetWidth(0.15f, 0.15f);
        dline.SetColors(Color.green, Color.green);
        dline.useWorldSpace = true;
        isMousePressed = false;
        pointsList = new List<Vector3>();
        lineParticle.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isMousePressed = true;
            dline.SetVertexCount(0);
            pointsList.RemoveRange(0, pointsList.Count);



        }
        else if (Input.GetMouseButtonUp(0))
        {
            isMousePressed = false;



        }

        if (isMousePressed)
        {

            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            if (!pointsList.Contains(mousePos))
            {
                pointsList.Add(mousePos);
                dline.SetVertexCount(pointsList.Count);
                dline.SetPosition(pointsList.Count - 1, (Vector3)pointsList[pointsList.Count - 1]);
                lineParticle.SetActive(true);
                lineParticle.transform.position = new Vector3(mousePos.x, mousePos.y, lineParticle.transform.position.z);
            }


        }


    }
}
