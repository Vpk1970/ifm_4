using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aluksen_luonti : MonoBehaviour
{
    public GameObject alus = null;
    public int elossa = 1;
    public Ajastin koe_aika;


    // Start is called before the first frame update
    void Start()
    {
        if (elossa == 1)
        {
            GameObject apualus = Instantiate(this.alus, new Vector3(0f, -4f, 0f), Quaternion.identity);
            elossa = 0;

        }

        koe_aika = gameObject.AddComponent<Ajastin>();// Ajastin luokka on koodia gameobject issa
        koe_aika.aseta_aika(5f);// sekunnit

    }

    // Update is called once per frame
    void Update()
    { 
        Debug.Log(koe_aika.tarkista_aika());

    }
}
