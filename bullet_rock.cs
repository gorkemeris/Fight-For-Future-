using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_rock : MonoBehaviour
    
{
    Vector3 vec;
    Vector3 vecforce;
    Rigidbody fizik;
    float missle_force;
    public int hiz;
    GameObject rocket;


    // Start is called before the first frame update
    void Start()
    {
        rocket = GameObject.FindGameObjectWithTag("rocket");

        fizik = gameObject.GetComponent<Rigidbody>();

        vec = new Vector3(-90 + rocket.transform.rotation.x*119.189f, rocket.transform.rotation.z * 119.047f, 1.5f );

        transform.rotation = Quaternion.Euler(vec);
        

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < 80)
        {
            vecforce = new Vector3(0, 1 * hiz, 0);
            fizik.AddForce(vecforce);
        }
        

        if (transform.position.y > rocket.transform.position.y + 80)
        {
            Destroy(gameObject);
        }

    }
    

    void missleforce()

    {
        

    }
}
