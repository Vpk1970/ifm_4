using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammus_liike_2 : MonoBehaviour
{
    [SerializeField]
    private float nopeus = 100f;
    private float yl�raja = 4f;

    // Start is called before the first frame update
    void Start()
    {
        //this.GetComponent<Rigidbody>().AddForce(Vector2.up * nopeus);
    }

    // Update is called once per frame
    void Update()
    {
        // Ammus liikkuu koneen nopeudesta riippumatta samalla nopeudella

        //this.GetComponent<Transform>().Translate(0f, nopeus * Time.deltaTime, 0f);

        this.GetComponent<Rigidbody2D>().MovePosition(transform.position + new Vector3(0f, nopeus * Time.deltaTime, 0f));

        //this.Ammus_6.GetComponent<Rigidbody2D>().AddForce(Vector2.up * nopeus);
        //Debug.Log(this.gameObject.name);

        if (this.GetComponent<Transform>().position.y > yl�raja)
        {
            Destroy(this.gameObject);

        }





    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals("Alien(Clone)"))
        {
            //GameObject.Find("Koodia").GetComponent<score_lives>().pisteet += 10;

            //Debug.Log(GameObject.Find("Koodia").GetComponent<score_lives>().pisteet);


            Destroy(this.gameObject);


        }
    }
}