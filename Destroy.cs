using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    GameObject spcshp;
    Rigidbody spchp_fizik;
    Rigidbody fizik;
    Vector3 vec;
    RaycastHit ray;
    GameObject exporock;
    Vector3 vec3;
    GameObject b_rocket;
    Vector3 vec1;
    void Start()
    {
        spcshp = GameObject.FindGameObjectWithTag("rocket");
        exporock = GameObject.FindGameObjectWithTag("exporock");
        fizik = gameObject.GetComponent<Rigidbody>();
        spchp_fizik = spcshp.GetComponent<Rigidbody>();
        b_rocket = GameObject.FindGameObjectWithTag("b_rocket");

       
    }

    
    void Update()
    {

        if (transform.position.y < spcshp.transform.position.y)
        {
            vec1 = new Vector3(spchp_fizik.position.x, spchp_fizik.position.y - 15, spchp_fizik.position.z);
            transform.position = vec1;
        }

        if (transform.position.y > spcshp.transform.position.y)
        {
            vec = new Vector3(spchp_fizik.position.x, spchp_fizik.position.y + 100, spchp_fizik.position.z);
            transform.position = vec;
        }


    }

     void OnTriggerEnter(Collider other)
    {

        Destroy(other.gameObject);
            
    }

    void olum_sayici()
    {

    }
 
}
