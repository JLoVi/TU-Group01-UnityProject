using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class PlayerNormalised2 : MonoBehaviour
{

    PlayerNormalised planetcore;

    void Awake()
    {
        planetcore = GameObject.FindGameObjectWithTag("PlanetCore").GetComponent<PlayerNormalised>();
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
    }

    void FixedUpdate()
    {
        planetcore.Attract(transform);
    }
}
