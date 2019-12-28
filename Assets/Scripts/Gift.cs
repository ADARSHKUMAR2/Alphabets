using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Gift : MonoBehaviour
{
    public GameObject[] display;
    public AudioSource _as;
    public AudioClip[] audioClipArray;
    Line_2 line_2;

    [Range(0f,1f)]
    public float Volume;
    //AudioSource audioSource; 
    private void Awake()
    {
        
        _as = GetComponent<AudioSource>();

    }

    void Start ()
    {
        Instantiate(display[Line_2.to_display_no], display[Line_2.to_display_no].transform.position, Quaternion.identity);

        _as.clip=audioClipArray[Line_2.to_display_no];
        _as.PlayOneShot(_as.clip);
        
    }
	
	void Update ()
    {
		
	}

    public void Back()
    {
        SceneManager.LoadScene("Choice Screen");
    }
}
