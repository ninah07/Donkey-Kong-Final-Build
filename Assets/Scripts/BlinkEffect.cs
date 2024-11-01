using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkEffect : MonoBehaviour
{

    public GameObject characterObject;

    public float repeatTime = 0.1f;


    void Start()
    {

    }

    void StateOfGameObject()
    {
        characterObject.SetActive(!characterObject.activeInHierarchy);
    }

    void Update()
    {

    }


    void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collide"); 
        InvokeRepeating("StateOfGameObject", 0.01f, repeatTime);
        Debug.Log("Ran invoke repeating");
        Invoke("StopBlinking", 1f);
        Debug.Log("Ran invoke repeating");
    }

    void StopBlinking()
    {
        CancelInvoke("StateOfGameObject");
        characterObject.SetActive(true);
        Debug.Log("Stopped invoking StateOfGameObject");
    }
}

