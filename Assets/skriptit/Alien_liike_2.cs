#define UNITY_ASSERTIONS

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using Unity.VisualScripting;
using System;
//using Debug = System.Diagnostics.Debug;


public class Alien_liike_2 : MonoBehaviour
{
    private float alku_x;
    private float loppu_x;

    private float liike_nopeus = 3f;
    private const float x_matka = 6f;

    //private float y_nopeus = 0f;
    private float y = -0.1f;

    //public AlienLuontiTehdas_2 luo;
    private float offset = 1.2f;
    public GameObject Alien_5;

    static int alienDeaths = 0;
    //public AlienLuontiTehdas_2 Luo_Alien;



    private void Awake()
    {
        alku_x = this.GetComponent<Transform>().position.x;
        loppu_x = alku_x + x_matka;

        UnityEngine.Debug.Log(alku_x);
        UnityEngine.Debug.Log(loppu_x);

        


    }
    // Start is called before the first frame update
    void Start()
    {
        //Luo_Alien = GameObject.Find("Koodia").GetComponent<AlienLuontiTehdas_2>().AlienLuonti_2();

        //Luo_Alien = this.GetComponent<AlienLuontiTehdas_2>().AlienLuonti_2();
        //UnityEngine.Debug.Log(this.gameObject.name);
        //luo = gameObject.GetComponent<AlienLuontiTehdas_2>().AlienLuonti_2();
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject.FindWithTag("Alien_tag").GetComponent<Transform>().Translate(liike_nopeus * Time.deltaTime, 0f, 0f);
        Alien_5.GetComponent<Transform>().Translate(liike_nopeus * Time.deltaTime, 0f, 0f);
        //this.GetComponent<Transform>().position.y -= y_nopeus;
        //

        //[Conditional(UNITY_ASSERTIONS)]
        //Debug.Assert(alku_x == loppu_x);

        // Jos alku_x on sama kuin loppu_x tulee ilmoitus konsoliin
        //UnityEngine.Debug.Assert(alku_x != loppu_x);

        if (this.GetComponent<Transform>().position.x >= loppu_x || this.GetComponent<Transform>().position.x < alku_x) // ???
        {
            liike_nopeus *= -1f;
            //y = -0.2f;
            Alien_5.transform.position = new Vector3(this.GetComponent<Transform>().position.x, this.GetComponent<Transform>().position.y + y, 0f);

            if (Alien_5.GetComponent<Transform>().position.y <= -2f)
            {
                //Application.Quit();
                Destroy(this.gameObject);


            }

        }
        /*if (this.GetComponent<Transform>().position.x < alku_x) // x <= alku_x ...muutos x < alku_x 
        {
            liike_nopeus *= -1f;
        }*/
        //this.GetComponent<Transform>().Translate(liike_nopeus * Time.deltaTime, 0f, 0f);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals("Ammus_5(Clone)"))
        {
            Destroy(this.gameObject);
            //Debug.Log("collision");
            alienDeaths += 1;
            if (alienDeaths == 32)
            {
                //Luo_Alien;
                GameObject.Find("Koodia").GetComponent<AlienLuontiTehdas_2>().AlienLuonti_2();

                /*for (float y = 1f; y <= 4f; y = y + 1f)
                {
                    for (float x = 1f; x <= 8f; x = x + 1f)
                    {
                        Alien_5.name = "alien";
                        _ = Instantiate(Alien_5, new Vector3(x - 8 * offset + 2, 5 - y * offset, 0f), Quaternion.identity);
                        
                    }
                }*/
                //System.Diagnostics.Debug.WriteLine(Alien_5.name);

                //luo.AlienLuonti_2();

                //GameObject.Find("AlienLuontiTehdas_2").GetComponent<AlienLuontiTehdas_2>().alienLuonti_2();
                alienDeaths = 0;

            }

            GameObject.Find("Koodia").GetComponent<Pisteet>().pisteet += 10;

        }
    }
}