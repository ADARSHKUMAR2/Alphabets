using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialLine : MonoBehaviour
{
    public Material[] mat;
    public LineRenderer lineRenderer;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
       
    }
    public void LineColor_1()
    {
        lineRenderer.material = mat[0];
        //  life++;
    }

    public void LineColor_2()
    {
        Debug.Log("Red Selected");
        lineRenderer.material = mat[1];
        // life++;
    }


    public void LineColor_3()
    {
        lineRenderer.material = mat[2];
        //  life++;
    }
    
}
