using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sayac : MonoBehaviour
{
    GameObject rocket;
    Vector3 vec;
    public Text belirtec;
    public Text sayac1;
    int a = 0;
    void Start()
    {
        rocket = GameObject.FindGameObjectWithTag("rocket");
        vec = transform.position - rocket.transform.position;


    }


    // Update is called once per frame
    void Update()

    {

        transform.position = rocket.transform.position + vec;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "a"|| other.tag == "b" || other.tag == "c")
        {

            a++;
            belirtec.text = "You could not hit all of the satellites.";
            sayac1.text = "Possibility to hit the earth   :" + a + "/" + 3200;
            

        }
    }
   

}
       


