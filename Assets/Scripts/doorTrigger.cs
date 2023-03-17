using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject door;

    bool doorOpen = false;

    // open door upward till 
    IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cube" && doorOpen == false)
        {
            doorOpen = true;
            for (int i = 0; i < 100; i++)
            {
                door.transform.Translate(0, 0.01f, 0);
                yield return new WaitForSeconds(0.01f);
            }
        }
    }

    // close door downward
    IEnumerator OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "cube" && doorOpen == true)
        {
            doorOpen = false;
            for (int i = 0; i < 100; i++)
            {
                door.transform.Translate(0, -0.01f, 0);
                yield return new WaitForSeconds(0.01f);
            }
        }
    }
}