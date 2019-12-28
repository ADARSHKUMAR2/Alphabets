using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour {
    [SerializeField]
    private GameObject LineGenPrefab;
    [SerializeField]
    private GameObject LinePointPrefab;
	void Update ()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            newPos.z = 0;
            CreatePointMarker(newPos);
        }

        if(Input.GetMouseButtonDown(1))
        {
            ClearAllPoints();
        }

        if(Input.GetKeyDown("e"))
        {
            GenerateNewLine();
        }
    }

    private void GenerateNewLine()
    {
        GameObject[] allPoints = GameObject.FindGameObjectsWithTag("PointMarker");
        Vector3[] allPointsPosition = new Vector3[allPoints.Length];

        if(allPoints.Length>=2)
        {
            for(int i=0;i<allPoints.Length;i++)
            {
                allPointsPosition[i] = allPoints[i].transform.position;
            }
            SpawnLineGen(allPointsPosition);
        }
    }

    private void ClearAllPoints()
    {
        GameObject[] allPoints = GameObject.FindGameObjectsWithTag("PointMarker");
        foreach(GameObject p in allPoints)
        {
            Destroy(p);
        }
    }
    private void CreatePointMarker(Vector3 pointPosition)
    {
        Instantiate(LinePointPrefab, pointPosition, Quaternion.identity);
    }

    private void SpawnLineGen(Vector3[] linePoints)
    {
        GameObject newLineGen = Instantiate(LineGenPrefab);
        LineRenderer lRend = newLineGen.GetComponent<LineRenderer>();

        lRend.positionCount=linePoints.Length;
        lRend.SetPositions(linePoints);

        //Destroy(newLineGen, 5);
    }
    
}
