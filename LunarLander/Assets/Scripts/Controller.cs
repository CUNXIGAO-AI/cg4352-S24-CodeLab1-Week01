using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Rigidbody rb;

    private float cubeSpeed = 3;
    
    private float timer;

    private bool startTimer;

    public GameObject myTimer;

    public TextMeshProUGUI myTimerUI;
    // Start is called before the first frame update
    void Start()
    {
        myTimer.SetActive(false);
        myTimerUI.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(0, cubeSpeed, 0));
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(0, -cubeSpeed, 0));
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-cubeSpeed, 0, 0));
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(cubeSpeed, 0, 0));
        }
        
        if (startTimer)
        {
            timer += Time.deltaTime;
            myTimerUI.text = timer.ToString("F2");
            if (timer >= 3)
            {
                timer = 3;
                myTimerUI.text = "LANDING COMPLETE!";
            }
        }

    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PlatForm")
        {
            myTimer.SetActive(true);
            startTimer = true;
            myTimerUI.text = timer.ToString("F2");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        startTimer = false;
        myTimerUI.text = " ";
        timer = 0;
    }
}
