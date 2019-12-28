using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Line_2 : MonoBehaviour
{
    public Material[] mat;
    Order order;
    public GameObject linePrefab;
    public GameObject currentLine;
    public LineRenderer lineRenderer;
    public EdgeCollider2D edgeCollider;
    public List<Vector2> fingerPositions;
    int a = 0;
    //static int score = 0;
    public Text score_win;
    
    public Text life_text;
    public Text gui;
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
    public static int to_display_no;

    int order_1 = 0;
    int order_2 = 0;
    int order_3 = 0;
    int order_4 = 0;
    int order_5 = 0;
    //static int life = 5;
    //public GameObject heart1, heart2, heart3, heart4, heart5;
    
    void Start ()
    {
       // life_text.text = "Lives: "+((int)life).ToString();
        gui.text=null;
        // heart1.gameObject.SetActive(true);
        // heart2.gameObject.SetActive(true);
        //  heart3.gameObject.SetActive(true);
        //  heart4.gameObject.SetActive(true);
        //  heart5.gameObject.SetActive(true);

        //mat = GetComponent<LineRenderer>().materials;
        //lineRenderer.material = mat[0];
        //lineRenderer.material = new Material(Shader.Find("Sprites/Default"));

    }


    void Update ()
    {
        /*
        switch(life)
        {
            case 5:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(true);
                heart5.gameObject.SetActive(true);
                break;

            case 4:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(true);
                heart5.gameObject.SetActive(false);
                break;

            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                break;

            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                break;

            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                break;

            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                break;

        }
        */
        if (Order.name_hit == "A")
        {
            to_display_no = 0;
            Instantiate(A1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "B")
        {
            to_display_no = 1;
            Instantiate(B1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "C")
        {
            to_display_no = 2;
            Instantiate(C1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "D")
        {
            to_display_no = 3;
            Instantiate(D1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "E")
        {
            to_display_no = 4;
            Instantiate(E1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "F")
        {
            to_display_no = 5;
            Instantiate(F1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "G")
        {
            to_display_no = 6;
            Instantiate(G1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "H")
        {
            to_display_no = 7;
            Instantiate(H1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "I")
        {
            to_display_no = 8;
            Instantiate(I1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "J")
        {
            to_display_no = 9;
            Instantiate(J1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "K")
        {
            to_display_no = 10;
            Instantiate(K1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "L")
        {
            to_display_no = 11;
            Instantiate(L1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "M")
        {
            to_display_no = 12;
            Instantiate(M1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "N")
        {
            to_display_no = 13;
            Instantiate(N1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "O")
        {
            to_display_no = 14;
            Instantiate(O1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "P")
        {
            to_display_no = 15;
            Instantiate(P1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "Q")
        {
            to_display_no = 16;
            Instantiate(Q1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "R")
        {
            to_display_no = 17;
            Instantiate(R1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "S")
        {
            to_display_no = 18;
            Instantiate(S1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "T")
        {
            to_display_no = 19;
            Instantiate(T1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "U")
        {
            to_display_no = 20;
            Instantiate(U1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "V")
        {
            to_display_no = 21;
            Instantiate(V1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "W")
        {
            to_display_no = 22;
            Instantiate(W1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "X")
        {
            to_display_no = 23;
            Instantiate(X1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "Y")
        {
            to_display_no = 24;
            Instantiate(Y1, transform.position, transform.rotation);
        }
        if (Order.name_hit == "Z")
        {
            to_display_no = 25;
            Instantiate(Z1, transform.position, transform.rotation);
        }



        if (order_1 == 1 && order_2 == 1 && order_3 == 1 && order_4 == 1 && order_5==1)
        {
            SceneManager.LoadScene("Scene_1_1");            
        }
        /*
        if(life<=0)
        {
            SceneManager.LoadScene("Lost_Screen");
            life = 5;
        }
        */
    }

    void CreateLine()
    {
        currentLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity);
        lineRenderer = currentLine.GetComponent<LineRenderer>();
        edgeCollider = currentLine.GetComponent<EdgeCollider2D>();
        fingerPositions.Clear();
        fingerPositions.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        fingerPositions.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        lineRenderer.SetPosition(0, fingerPositions[0]);
        lineRenderer.SetPosition(1, fingerPositions[1]);
        edgeCollider.points = fingerPositions.ToArray();
        // a++;
        //Debug.Log(a);
    }

    void UpdateLine(Vector2 newFingerPos)
    {
        fingerPositions.Add(newFingerPos);
        lineRenderer.positionCount++;
        
        lineRenderer.SetPosition(lineRenderer.positionCount - 1, newFingerPos);
        edgeCollider.points = fingerPositions.ToArray();
    }

    public void FixedUpdate()
    {
        if(Input.GetMouseButton(0))
        {
            int specificLayerMask = LayerMask.GetMask("Player");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity, specificLayerMask);

                if (hit)
                {
                    Debug.Log(hit.collider.gameObject.name);
                }
                
                if(hit.collider.tag=="Player")
                {
                    CreateLine();

                }


            if (Input.GetMouseButton(0))
            {
                if (hit.collider.tag == "Player")
                {
                    Vector2 tempFingerPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    if (Vector2.Distance(tempFingerPos, fingerPositions[fingerPositions.Count - 1]) > .1f)
                    {
                        UpdateLine(tempFingerPos);
                    }
                }
                    
            }

            if (hit.collider.name == "Ground" )
                {
                if (EventSystem.current.currentSelectedGameObject != null) 
                   return;
                /*
                if (life > 0)
                    {
                        life--;
                        life_text.text = ((int)life).ToString();
                        StartCoroutine(ShowMessage("Try Again", 2));
                      //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

                    }
                 */
                }

                if(hit.collider.name=="Back")
                {
                    SceneManager.LoadScene("Choice Screen");
                }

                if (hit.collider.gameObject.name == "1_")
                {
                    order_1 = 1;
                }

                if (hit.collider.gameObject.name == "2_")
                {
                    if (order_1 == 1)
                    {
                        order_2 = 1;
                    }
                    else
                    {
                        //life--;
                        StartCoroutine(ShowMessage("Try Again", 2));
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                    }
                }

                if (hit.collider.gameObject.name == "3_")
                {
                    if (order_1 == 1 && order_2 == 1)
                    {
                        order_3 = 1;
                    }
                    else
                    {
                        //life--;
                        StartCoroutine(ShowMessage("Try Again", 2));
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                    }
                }

                if (hit.collider.gameObject.name == "4_")
                {
                    if (order_1 == 1 && order_2 == 1 && order_3 == 1)
                    {
                        order_4 = 1;
                    }
                    else
                    {
                        //life--;
                        StartCoroutine(ShowMessage("Try Again", 2));
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                    }
                }

                if (hit.collider.gameObject.name == "5_")
                {
                    if (order_1 == 1 && order_2 == 1 && order_3 == 1 && order_4 == 1)
                    {
                        order_5 = 1;
                       // score++;
                        //score_win.text= 
                    }
                    else
                    {
                      //  life--;
                        StartCoroutine(ShowMessage("Try Again", 2));
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                    }
                }

                if (hit.collider.name == "Back")
                {
                    Debug.Log("Back Button");
                    SceneManager.LoadScene("Choice Screen");
                }

        }
    }

    IEnumerator ShowMessage(string message, float delay)
    {
        gui.text = message;
        gui.enabled = true;
        yield return new WaitForSeconds(delay);
        gui.enabled = false;
    }

   
    public void Back_Button()
    {   
            Debug.Log("Back Button Pressed");
            SceneManager.LoadScene("Choice Screen");       
    }
    
}
