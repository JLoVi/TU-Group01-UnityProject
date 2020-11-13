using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;

    public Text PointerText;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot() 
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            PointerText.text = hit.transform.name;

            Debug.Log(hit.transform.name);
        }
    }
}
