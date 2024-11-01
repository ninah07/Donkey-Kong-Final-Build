using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBarrel : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.name == "Barrel1" || other.gameObject.name == "Barrel2" || other.gameObject.name == "Barrel3")
        {
            DestroyObjectDelayed();
        }

    }

    void DestroyObjectDelayed()
    {
        Destroy(gameObject, 1);
    }

}


