﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempura : MonoBehaviour
{
    private Vector2 mou;
    private Vector2 tar;
    public GameObject mu;
    public float taka;
    public float off;
    public static float max2;
    public static float min2;
    public bool mode;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Nexxt nexxt;
        nexxt = mu.GetComponent<Nexxt>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale != 0)
        {
            Nexxt nexxt;
            nexxt = mu.GetComponent<Nexxt>();
            mou = Input.mousePosition;
            if (Input.GetKeyDown(KeyCode.LeftShift) | Input.GetKeyDown(KeyCode.RightShift))
            {
                mode = !mode;
            }
            if (mode == true)
            {
                tar = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                this.transform.position = new Vector2(tar.x + off, taka);
                this.transform.position = new Vector2(Mathf.Clamp(tar.x, min2, max2) + off, taka);
            }
            else
            { 
                
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    tar.x += speed;
                }else
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    tar.x -= speed;
                }
       
                this.transform.position = new Vector2(Mathf.Clamp(tar.x, min2, max2) + off, taka);
            }
            if (Spown.knifetime == true)
            {
                min2 = -19.8f;
                max2 = 21.8f;
            }else
            if (nexxt.nex == 0)
            {
                min2 = -18.3f;
                max2 = 22.5f;
            }else
            if (nexxt.nex == 1)
            {
                min2 = -17.9f;
                max2 = 22.1f;
            }else
            if (nexxt.nex == 2)
            {
                min2 = -17.8f;
                max2 = 21.8f;
            }else
            if (nexxt.nex == 3)
            {
                min2 = -16.2f;
                max2 = 21f;
            }else
            if (nexxt.nex == 4)
            {
                min2 = -15.3f;
                max2 = 19.3f;
            }
        }
       

    }
}
