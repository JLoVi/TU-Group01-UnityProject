using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNormalised : MonoBehaviour
{

    public void Attract(Transform body)
    {
        Vector3 targetDir = (body.position - transform.position).normalized;
        Vector3 bodyUp = body.up;

        body.rotation = Quaternion.FromToRotation(bodyUp, targetDir) * body.rotation;
    }
}