using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockChecker1 : MonoBehaviour
{

    public static bool blocked1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player2")
        {
            blocked1 = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "player2")
        {
            blocked1 = false;
        }
    }

}
