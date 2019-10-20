using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class expo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        dest();
    }
    void dest ()
        {
        if (gameObject.transform.position.x > -100)
        {
            Destroy(gameObject, 5);

                }
        }
}
