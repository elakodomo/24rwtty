﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamewe : MonoBehaviour
{
    public bool gameovern;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject mos = GameObject.Find("NEMPR");
        gameovern = true;
        this.transform.parent = mos.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameovern == true)
        {
            if (gameObject.transform.position.y >= 28)
            {
                gameovern =false;
                Debug.Log("ゲームオーバー");
                Time.timeScale = 0;
                gameover.over();

            }
        }
        
    }
}
