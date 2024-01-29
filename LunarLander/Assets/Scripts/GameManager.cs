using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public GameObject myStartMenu;

    public GameObject myCube;

    public GameObject myPlatForm;
    
    // Start is called before the first frame update
    void Start()
    {
        myStartMenu.SetActive(true);
        myCube.SetActive(false);
        myPlatForm.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myStartMenu.SetActive(false);
            myCube.SetActive(false);
            myPlatForm.SetActive(false);
        }
        
        if (Input.GetKeyUp(KeyCode.Space))
        {
            myCube.SetActive(true);
            myCube.transform.position = new Vector3(0, 4, 0);
            myPlatForm.SetActive(true);
            var positionValueX = Random.Range(-8f,8f);
            var positionValueY = Random.Range(-4f,-1f);
            myPlatForm.transform.position = new Vector3(positionValueX, positionValueY, 0);
        }
    }
}
