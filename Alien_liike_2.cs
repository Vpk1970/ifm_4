#define UNITY_ASSERTIONS

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Diagnostics;
using Unity.VisualScripting;
//using System;
using System.Xml.Schema;
using UnityEngine.UIElements;
//using System;
//using Debug = System.Diagnostics.Debug;


public class Alien_liike_2 : MonoBehaviour
{
    private float alku_x; // Alienin alkupiste x
    private float loppu_x; // Alienin loppupiste x

    private int suunta; // Alienin liikkumissuunta 1 tai -1
    private float x_matka; // Alienien kulkema matka x suunnassa
    //private bool oikealle;
    private float nopeus; // Alienien liikkumis nopeus
    private bool suunnanVaihto; // Vaihdetaanko alienien liikkumissuuntaa...true tai false
    //private bool alienienLuonti;
    //private float aikaclamp;
    private Vector3 origAlienPos; // Alienin alkupiste
    private Vector3 origAlienPosMax; // Alienin loppupiste

    private float yy; // Alienien liikkuminen y suunnassa

    private float y_alienAlareuna; // Alienien alin piste

    public GameObject Alien_5;

    public GameObject Ammus_5;
    //private GameObject apuluonti;

    public AlienLuontiTehdas_2 alienlt; // AlienLuontiTehdas_2 koodi

    static int alienDeaths = 0; // Alienien kuolemien lkm

    private float xMin; // Clampin alaraja jonka yläpuolella suunnanVaihto on true
    private float xMax; // Clampin yläraja jonka alapuolella suunnanVaihto on true

    public Transform _transform;

    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        suunta = 1;
        x_matka = 8.0f;
        //oikealle = true;
        nopeus = 2.5f;
        suunnanVaihto = false;
        yy = 0.1f;
        y_alienAlareuna = -2f;
                
        origAlienPos = this.GetComponent<Transform>().position;
        origAlienPosMax = new Vector3(this.GetComponent<Transform>().position.x + x_matka, this.GetComponent<Transform>().position.y, this.GetComponent<Transform>().position.z);

        xMin = 0.2f * x_matka;
        xMax = 0.2f * x_matka;

        alku_x = this.GetComponent<Transform>().position.x;
        loppu_x = this.GetComponent<Transform>().position.x + x_matka; // oli 7

        AlienLuontiTehdas_2 alienlt = GetComponent<AlienLuontiTehdas_2>();

        _transform = this.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {

        //[Conditional(UNITY_ASSERTIONS)]
        //Debug.Assert(alku_x == loppu_x);

        // Jos alku_x on sama kuin loppu_x tulee ilmoitus konsoliin
        //UnityEngine.Debug.Assert(suunnanVaihto == true);

        this._transform.position += nopeus * Time.deltaTime * new Vector3(1f * suunta, 0f, 0f);// localPosition ???
        
        //Debug.Log(Time.deltaTime.ToString());
        //Debug.Log(this.transform.position.x);

        if (this._transform.position.x <= alku_x)
        {
            this._transform.position = origAlienPos - new Vector3( 0f, yy += 0.1f, 0f);

            //Debug.Log(this.transform.position.x);

        }
        if (this._transform.position.x >= loppu_x)
        {
            this._transform.position = origAlienPosMax - new Vector3( 0f, yy += 0.1f, 0f);

            //suunnanVaihto = true;


        }
     

        if ((this._transform.position.x >= alku_x + xMin) || (this._transform.position.x <= loppu_x - xMax))
        {
            suunnanVaihto = true;
            //Debug.Log(suunnanVaihto);
            //alienienLuonti = true;

        }
        else
        {
            suunnanVaihto = false;
            //Debug.Log(suunnanVaihto);
        }

        if (((this._transform.position.x >= loppu_x) && (suunnanVaihto)) || ((this._transform.position.x <= alku_x) && (suunnanVaihto))) // ???
        {
            suunta *= -1;
            suunnanVaihto = false;
            //Debug.Log(suunnanVaihto);

            //AlienLuontiTehdas_2 alienlt = GameObject.Find("Koodia").GetComponent<AlienLuontiTehdas_2>();

            //alienlt.Invoke(nameof(AlienLuontiTehdas_2.AlienLuonti_2), 0.0f);

            //alku_x = this.GetComponent<Transform>().position.x;
            //loppu_x = this.GetComponent<Transform>().position.x + x_matka;
         


            //Debug.Log("");
            Debug.Log(this._transform.position.x);

            //this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - yy, 0f);

            if (this.GetComponent<Transform>().position.y <= y_alienAlareuna)
            {
                //Application.Quit();
                Destroy(this.gameObject);

            }

        }

        /*if ((this.transform.position.x <= alku_x) && (alienienLuonti == true))
        {
            //suunta *= -1.0f;
            alienienLuonti = false;

            AlienLuontiTehdas_2 alienlt = GameObject.Find("Koodia").GetComponent<AlienLuontiTehdas_2>();

            alienlt.Invoke(nameof(AlienLuontiTehdas_2.AlienLuonti_2), 0.0f);

            alku_x = this.GetComponent<Transform>().position.x;
            loppu_x = this.GetComponent<Transform>().position.x + x_matka;

        }*/

        /*if ((this.transform.position.x <= alku_x) && (alienienLuonti == true))
        {
            foreach (GameObject o in GameObject.FindGameObjectsWithTag("Alien_tag"))
            {
                Destroy(o);
            }



            //Destroy(GameObject.Find("Alien"));


            AlienLuontiTehdas_2 alienlt = GameObject.Find("Koodia").GetComponent<AlienLuontiTehdas_2>();

            alienlt.Invoke(nameof(AlienLuontiTehdas_2.AlienLuonti_2), 0.0f);

            alienienLuonti = false;

            alku_x = this.GetComponent<Transform>().position.x;
            loppu_x = this.GetComponent<Transform>().position.x + x_matka;

        }*/
    }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Equals("Ammus_5(Clone)"))
            {
                //Destroy(this.Ammus_5);

                Destroy(this.gameObject);
                //Debug.Log("collision");
                alienDeaths += 1;
                if (alienDeaths == 32)
                {
                    alienDeaths = 0;

                    AlienLuontiTehdas_2 alienlt = GameObject.Find("Koodia").GetComponent<AlienLuontiTehdas_2>();

                    alienlt.Invoke(nameof(AlienLuontiTehdas_2.AlienLuonti_2), 3.0f);

                }

                GameObject.Find("Koodia").GetComponent<Pisteet>().pisteet += 10;
            }
        }

    }

