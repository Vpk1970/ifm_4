#define UNITY_ASSERTIONS

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
//using Debug = System.Diagnostics.Debug;


public class Alien_liike : MonoBehaviour
{
    private float alku_x;
    private float loppu_x;

    private float liike_nopeus = 3f;
    private const float x_matka = 6f;

    // Start is called before the first frame update
    void Start()
    {
        alku_x = GetComponent<Transform>().position.x;
        loppu_x = alku_x + x_matka;
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Transform>().Translate(liike_nopeus * Time.deltaTime, 0f, 0f);
        //[Conditional(UNITY_ASSERTIONS)]
        //Debug.Assert(alku_x == loppu_x);

        // Jos alku_x on sama kuin loppu_x tulee ilmoitus konsoliin
        UnityEngine.Debug.Assert(alku_x != loppu_x);

        if (this.GetComponent<Transform>().position.x >= loppu_x) // ???
        {
            liike_nopeus *= -1f;
        }
        if (this.GetComponent<Transform>().position.x < alku_x) // x <= alku_x ...muutos x < alku_x 
        {
            liike_nopeus *= -1f;
        }
        //this.GetComponent<Transform>().Translate(liike_nopeus * Time.deltaTime, 0f, 0f);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals("Ammus_5(Clone)"))
        {
            Destroy(this.gameObject);
            //Debug.Log("collision");
        }
    }
}