using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList.Element_Adder_Menu;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Aluksenliikkuminen : MonoBehaviour
{
    private float liikkumis_nopeus = 10f;
    private float x_oikea_reuna = 8;
    private float x_vasen_reuna = -8;

    public int elamat = 3;
    public GameObject alus = null;
    private GameObject lives_teksti = null;

    // Start is called before the first frame update
    void Start()
    {
        this.lives_teksti = GameObject.Find("lives_text");
        //this.lives_teksti.GetComponent<Text>().text = "Lives " + elamat;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (this.GetComponent<Transform>().position.x < x_oikea_reuna)
            {
                //this.GetComponent<Rigidbody>().position = Vector3.zero;
                this.GetComponent<Transform>().Translate(liikkumis_nopeus * Time.deltaTime, 0f, 0f);//Time.deltaTime; sama nopeus eri koneilla

            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.GetComponent<Transform>().position.x > x_vasen_reuna)
            {
                //this.GetComponent<Rigidbody>().MovePosition(transform.position + new Vector3(0f, liikkumis_nopeus * Time.deltaTime, 0f));
                this.GetComponent<Transform>().Translate(-liikkumis_nopeus * Time.deltaTime, 0f, 0f);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals("Alien_ammus_1(Clone)"))
        {
            this.alus.SetActive(false);//Destroy(this.gameObject);
            this.elamat -= 1;
            //Debug.Log(elamat);
            this.lives_teksti.GetComponent<Text>().text = "Lives " + elamat;

            // Tähän väliin ajastimella tauko

            this.alus.SetActive(true);
            GameObject apualus = Instantiate(this.alus, new Vector3(0f, -4f, 0f), Quaternion.identity);
            
            //apualus.name = "ship(Clone)";
            //Debug.Log(apualus.name);

            if (this.elamat <= 0)
            {
                //elossa = 0;
                //Debug.Log("Uusi_alus");
                Destroy(this.gameObject);
                //this.alus.SetActive(false);
                //GameObject apualus = Instantiate(this.alus, new Vector3(0f, -4f, 0f), Quaternion.identity);
                //Debug.Log(elamat);
                //this.elamat = 3;
            }
        }
    }
}
