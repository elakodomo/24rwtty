﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spown : MonoBehaviour
{
    public GameObject[] kao;
    private Vector2 mousePos;
    public static bool ok;
    public bool fruok;
    public static bool gamew;
    public GameObject sui;
    public GameObject t2i;
    public GameObject t3i;
    public GameObject sen;
    public int number;
    public AudioClip pon;
    public GameObject knifes;
    public static bool knifetime;
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        //Cre(false);
        Nexxt nexxt;
        nexxt = t2i.GetComponent<Nexxt>();
        ok = false;


    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale != 0)
        {
            if (knifetime == false)
            {
                if (ruret.ivent == false)
                {
                    if (Input.GetKeyDown(KeyCode.Space) | Input.GetKeyDown(KeyCode.W) | Input.GetKeyDown(KeyCode.O))
                    {

                        Debug.Log("oooooooooooooooooooooooooooooooooooooooooooo");
                        if (ok == true)
                        {

                            fruok = true;
                            Nexxt nexxt;
                            nexxt = t2i.GetComponent<Nexxt>();
                            int fff = nexxt.nex;
                            if (nexxt.nex == 0)
                            {
                                tempura.min2 = -18.3f;
                                tempura.max2 = 22.5f;
                            }
                            if (nexxt.nex == 1)
                            {
                                tempura.min2 = -17.9f;
                                tempura.max2 = 22.1f;
                            }
                            if (nexxt.nex == 2)
                            {
                                tempura.min2 = -17.8f;
                                tempura.max2 = 21.8f;
                            }
                            if (nexxt.nex == 3)
                            {
                                tempura.min2 = -16.2f;
                                tempura.max2 = 21f;
                            }
                            if (nexxt.nex == 4)
                            {
                                tempura.min2 = -15.3f;
                                tempura.max2 = 19.3f;
                            }
                            // Debug.Log(fff);
                            Cre(fff);
                            audioSource = GetComponent<AudioSource>();
                            audioSource.PlayOneShot(pon);
                        }

                    }
                }
            }
         
           
        }
            


    }

    void kaoi()
    {
  
    }

    public void Cre(int k)
    {
        if (ruret.ivent == false)
        {
            GameObject moss = GameObject.Find("NEMPR");
            ok = false;
            sen.gameObject.SetActive(false);
            Nexxt nexxt;
            nexxt = t2i.GetComponent<Nexxt>();
            number++;
            GameObject sui = Instantiate(kao[k], transform.position, Quaternion.identity);
            sui.name = number.ToString();
            //sui.transform.parent = this.transform;
            var rb = sui.GetComponent<Rigidbody2D>();
            //rb.bodyType = RigidbodyType2D.Kinematic;
            rb.bodyType = RigidbodyType2D.Dynamic;
            sui.transform.parent = null;
            sui.transform.parent = moss.transform;
            GameObject cd = transform.GetChild(0).gameObject;
            Destroy(cd);
            //Invoke("no", 0f);

            //Debug.Log(nexxt.nex);

        }     

       
    }

    public void Tugi(int k)
    {
        sen.gameObject.SetActive(true);
        ok = true;
        Nexxt nexxt;
        nexxt = t2i.GetComponent<Nexxt>();
        nexxt.nexp = Random.Range(0, nexxt.max);
        GameObject sui = Instantiate(kao[k], transform.position, Quaternion.identity);
        sui.layer = 8;
        sui.transform.parent = this.transform;
        var rb = sui.GetComponent<Rigidbody2D>();
        //var col = sui.GetComponent<Collider2D>();
        //var col2 = sui.GetComponent<Collider2D>();
        //Destroy(sui.gameObject.transform.GetComponent<Collider2D>());
        //Destroy(sui.gameObject.transform.GetComponent<Collider2D>());
        rb.bodyType = RigidbodyType2D.Kinematic;
       // col.isTrigger = true;
        //col2.isTrigger = true;
        //rb.bodyType = RigidbodyType2D.Dynamic;
        //sui.transform.parent = null;
       // Debug.Log(nexxt.nex);
        //Debug.Log("sd,sjklfmjel");
        //CancelInvoke();




    }

    public void no()
    {
        if(fruok == true)
        {
            fruok = false;
            Nexxt nexxt;
            nexxt = t2i.GetComponent<Nexxt>();
            nexxt.nex = Random.Range(1, nexxt.max);
            int fff = nexxt.nex;
            nexxt.nex = nexxt.nexp;
            nexxt.key();
        }
        if (fruok == false)
        {
            //Debug.Log("死ぬかと思った...");
        }

    }

    public void oky()
    {
        if (Time.timeScale != 0)
        {
            if (knifetime == false)
            {
                if (ruret.ivent == false)
                {

                    Debug.Log("oooooooooooooooooooooooooooooooooooooooooooo");
                    if (ok == true)
                    {

                        fruok = true;
                        Nexxt nexxt;
                        nexxt = t2i.GetComponent<Nexxt>();
                        int fff = nexxt.nex;
                  
                        if (nexxt.nex == 0)
                        {
                            tempura.min2 = -18.3f;
                            tempura.max2 = 22.5f;
                        }
                        if (nexxt.nex == 1)
                        {
                            tempura.min2 = -17.9f;
                            tempura.max2 = 22.1f;
                        }
                        if (nexxt.nex == 2)
                        {
                            tempura.min2 = -17.8f;
                            tempura.max2 = 21.8f;
                        }
                        if (nexxt.nex == 3)
                        {
                            tempura.min2 = -16.2f;
                            tempura.max2 = 21f;
                        }
                        if (nexxt.nex == 4)
                        {
                            tempura.min2 = -15.3f;
                            tempura.max2 = 19.3f;
                        }

                        // Debug.Log(fff);
                        Cre(fff);
                        audioSource = GetComponent<AudioSource>();
                        audioSource.PlayOneShot(pon);
                    }


                }
            }


        }
    }

    public void kmade()
    {
        if (ok == true)
        {

            if (knifetime == false)
            {
                if (knifekaisuu.naif != 0)
                {
                    knifes.gameObject.SetActive(true);

                    knifetime = true;
                    ok = true;
                    GetComponent<Spown>().enabled = false;
                    knifes.GetComponent<knifeotoshi>().enabled = true;
                    knifes.GetComponent<knifeotoshi>().Tugi();
                    this.gameObject.SetActive(false);
                }
            }
        }
    }

    




}
