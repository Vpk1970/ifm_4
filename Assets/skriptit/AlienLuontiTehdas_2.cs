using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienLuontiTehdas_2 : MonoBehaviour
{
    public GameObject Alien_5;
    public float offset = 1.2f; // alienien väli joka suunnassa

    // Start is called before the first frame update
    void Start()
    {
        /*for (float y = 1f; y <= 4f; y = y + 1f)
        {
            for (float x = 1f; x <= 8f; x = x + 1f)
            {
                GameObject apualien = Instantiate(Alien_5, new Vector3(x - 8 * offset + 2, 5 - y * offset, 0f), Quaternion.identity);
            }   
        }*/
        AlienLuonti_2();

    }

    // Update is called once per frame
    void Update()
    {
    }
    public GameObject AlienLuonti_2()
    {
        for (float y = 1f; y <= 4f; y = y + 1f)
        {
            for (float x = 1f; x <= 8f; x = x + 1f)
            {
                _ = Instantiate(Alien_5, new Vector3(x - 8 * offset + 2, 5 - y * offset, 0f), Quaternion.identity);
            }
        }
        return gameObject;

        //Alien_5.name = "alien";

    }
}
/* Pseudoa:
 * 
 * Begin
 *  offset = 1.2
 *      for y = 1 to 4
 *          for x = 1 to 8
 *              Luo alien_5(x - 8 * offset + 2, 3 - y * offset + 2, 0)...5 - y * offset
 *          endfor
 *      endfor
 * Endbegin
 */

