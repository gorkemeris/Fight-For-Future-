using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrashMovement : MonoBehaviour
{
    Rigidbody fizik;
    Rigidbody faa;
    GameObject camm;
    Vector3 vec;
    public GameObject exx;
    // Start is called before the first frame update
    void Start()
    {
        camm = GameObject.FindGameObjectWithTag("rocket");
        fizik = GetComponent<Rigidbody>();
        fizik.angularVelocity = Random.insideUnitSphere * 40;
        Vector3 vec = new Vector3 (0, 0, 0);
        faa = camm.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       // abbbbb();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "rocket")
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            
            Invoke("anamenu",3);
            
        }
    }
    void abbbbb()
    {
        /*if (transform.position.z < 100)
        {
            fizik.velocity = (vec);

        }
       */ 


    }
    void anamenu()
    {
        SceneManager.LoadScene("Anamenu");
    }
}
