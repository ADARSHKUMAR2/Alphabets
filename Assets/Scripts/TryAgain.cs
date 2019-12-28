using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{
    Line_2 line_2;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void try_again()
    {
        SceneManager.LoadScene("Choice Screen");
        //line_2.life = 5;
    }
}
