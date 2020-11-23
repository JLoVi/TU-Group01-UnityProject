using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public float damage = 10f;
    public float expiryTime = 0f;

 
    void Start()
    {
        Destroy(gameObject, expiryTime);
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player") Destroy(gameObject);
    }
}
