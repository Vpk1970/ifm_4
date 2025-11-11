using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;


public class Malienkoodi : MonoBehaviour
{
    public GameObject mAlien_2 = null;
    private float liikeNopeus = 5f;
    /*private float rand;
    private bool random_luo;

    private bool luo_lippu;
    private bool liiku_lippu;
    private bool mAlien_loppu_x;
    private float ajastinlaskuri = 0f;*/

    public GameObject paukku_2 = null;// Räjähdys animaatio

    public GameObject explosion_2 = null; // Räjähdys ääniefekti

    //GameObject gameObject1 = Instantiate(this.gameObject, new Vector3(-10f, 4.5f, 0f), Quaternion.identity);
    // Start is called before the first frame update
    void Start()
    {
        //GameObject gameObject1 = Instantiate(mAlien_2, new Vector3(-10f, 4.5f, 0f), Quaternion.identity);
        //System.Random rand = new();

        //System.Random rand = new();

        //Invoke(nameof(luo_mAlien), rand.Next(1, 3));

        //this.gameObject.SetActive(true);
        //luo_lippu = false;
        //liiku_lippu = false;
        //mAlien_loppu_x = true;
        //random_luo = true;


        //this.mAlien.SetActive(true);
        //mAlien_2 = GameObject.Find("mAlien");
        /*Debug.Log(mAlien_2);
        if (mAlien_2 == null)
        {
            Debug.LogError("mAlien GameObject not found!");
        }*/
        //if (mAlien_2 == mAlien)
        //{
        //    Debug.Log("mAlien");

        //}
        //paukku_2 = GameObject.Find("Paukku_2");

    }

    // Update is called once per frame
    void Update()
    {
        
        
        StartCoroutine(liiku());

   
        
                
    }

    private void OnDisable()
    {
        StopCoroutine(liiku());

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals("Ammus_5(Clone)"))
        {
            //System.Random rand = new();
            //mAlien_2.GetComponent<Transform>().SetPositionAndRotation(Vector3(rand.Next(-13, -10), 0f, 0f));
            

            //Destroy(mAlien_2);
            //mAlien_loppu_x = true;

            GameObject.Find("Koodia").GetComponent<Pisteet>().pisteet += 100;

            GameObject.Find("Explosion_2").GetComponent<AudioSource>().Play();
            
            //mAlien.SetActive(false); ***
            
            GameObject apupaukku_2 = Instantiate(paukku_2, this.gameObject.GetComponent<Transform>().position, Quaternion.identity);

            Destroy(apupaukku_2, 1f);

            System.Random rand = new();
            int x = rand.Next(-66, -26);
            Debug.Log(x);

            //Invoke(nameof(luo_mAlien), rand.Next(1, 3));
            //luo_mAlien();
            mAlien_2.GetComponent<Transform>().SetPositionAndRotation(new Vector3((float)x, 4.3f, 0f), Quaternion.identity);



        }
    }
    

    IEnumerator liiku()
    {

        //if (mAlien_loppu_x == false)
        //{
        //System.Random rand = new();
            mAlien_2.GetComponent<Transform>().Translate(liikeNopeus * Time.deltaTime, 0f, 0f);
            //mAlien_loppu_x = false;

            if (mAlien_2.GetComponent<Transform>().position.x >= 13f)
            {
                System.Random rand = new();
                int x = rand.Next(-66, -26);
                Debug.Log(x);

                mAlien_2.GetComponent<Transform>().SetPositionAndRotation(new Vector3((float)x, 4.3f, 0f), Quaternion.identity);

            //mAlien_loppu_x = true;
            //Destroy(mAlien_2);
            //luo_mAlien();
            //System.Random rand = new();

            //Invoke(nameof(luo_mAlien), rand.Next(1, 3));

            //System.Random rand = new();
            //Invoke(nameof(luo_mAlien), rand.Next(0, 5));


            //this.gameObject.SetActive(true);
            //mAlien.gameObject.transform.position = new Vector3(-10f, 4.5f, 0f); ***
            //random_luo = true;
            //mAlien_loppu_x = true;
            //liiku_lippu = false;
            //Destroy(mAlien);
            //mAlien.SetActive(false); ***

            yield return new WaitForEndOfFrame(); // yield return null;

                        
        }
        //}



    }
    public void luo_mAlien()
    {
        
            //System.Random rand = new System.Random();
            
            //int x = rand.Next(-46, -13);
            //{
            //GameObject gameObject1 = Instantiate(mAlien_2, new Vector3(-10f, 4.5f, 0f), Quaternion.identity);
            

            //liiku_lippu = true;
            //}
        
        

    }

}

