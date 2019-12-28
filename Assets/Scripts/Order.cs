using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Order : MonoBehaviour
{
    Line_2 line_2;
    public GameObject[] alphabets;
    public GameObject A1;
    public GameObject B1;
    public GameObject C1;
    public GameObject D1;
    public GameObject E1;
    public GameObject F1;
    public GameObject G1;
    public GameObject H1;
    public GameObject I1;
    public GameObject J1;
    public GameObject K1;
    public GameObject L1;
    public GameObject M1;
    public GameObject N1;
    public GameObject O1;
    public GameObject P1;
    public GameObject Q1;
    public GameObject R1;
    public GameObject S1;
    public GameObject T1;
    public GameObject U1;
    public GameObject V1;
    public GameObject W1;
    public GameObject X1;
    public GameObject Y1;
    public GameObject Z1;
    public static int selected;
    public static string name_hit = "";

    void Start ()
    {
        alphabets = GameObject.FindGameObjectsWithTag("Player");
        for(int i=0;i<alphabets.Length;i++)
        {
            //Debug.Log(GameObject.FindGameObjectsWithTag("Player"));
        }
	}

    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);

            if (hit.collider.tag=="Player")
            {
                SceneManager.LoadScene("Scene_1");
                name_hit = hit.collider.name;
                Debug.Log(name_hit);
            }
        }
    }    
}
