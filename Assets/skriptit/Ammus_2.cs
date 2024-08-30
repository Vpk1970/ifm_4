using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

// T‰m‰ tiedosto liitet‰‰n alukseen

public class Ammus_2 : MonoBehaviour
{
    public GameObject ammus_3 = null;
    public GameObject alus_3 = null;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            GameObject apuammus = Instantiate(this.ammus_3, new Vector3(this.alus_3.GetComponent<Transform>().position.x,
                this.alus_3.GetComponent<Transform>().position.y + 0.9f, 0f), Quaternion.identity);
            //Debug.Log("Ammus luonti");



        }
    }
}
