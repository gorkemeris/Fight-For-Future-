using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BigMetal : MonoBehaviour
{
    Rigidbody fizik;
    Rigidbody fizikgemi;
    

    GameObject b_rocket;
    GameObject rocket;
    GameObject expoGemi;
    
    Vector3 vec2;
    int bigmetal_hiz = 3;
    float bigmetal_time = 0;
    GameObject expometal;

    GameObject gameobject1;
    GameObject gameobject2;
    GameObject gameobject3;

    public Text belirtec;
    public Text sayac;
    int a=0;

    // Start is called before the first frame update
    void Start()
    {
        b_rocket = GameObject.FindGameObjectWithTag("b_rocket");
        rocket = GameObject.FindGameObjectWithTag("rocket");
        expometal = GameObject.FindGameObjectWithTag("Expometal");
        fizik = GetComponent<Rigidbody>();
        expoGemi = GameObject.FindGameObjectWithTag("exporock");
        fizik.angularVelocity = Random.insideUnitSphere * bigmetal_hiz;
        gameobject1 = GameObject.FindGameObjectWithTag("a");
        gameobject2 = GameObject.FindGameObjectWithTag("b");
        gameobject3 = GameObject.FindGameObjectWithTag("c");
        try
        {
            fizikgemi = rocket.GetComponent<Rigidbody>();
        }
        catch
        {
            int ab = 5;
        }

        StartCoroutine(random_Bigmetal());

        
       

    }

    // Update is called once per frame

    void Update()

    {
        

        createMetal();
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "rocket")

        {

            Vector3 vec2 = transform.position;
            Instantiate(expoGemi, vec2, Quaternion.identity);
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);

            Invoke("anamenu", 3);

        }

        if (other.tag == "b_rocket")

        {
            Vector3 vec1 = transform.position;
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            Instantiate(expometal, vec1, Quaternion.identity);

           
        }

       

    }
    

    void createMetal()
    {


        if (gameObject.transform.position.y < -50)
        {

            fizik.velocity = new Vector3(0, 0, 0);

        }

    }

    IEnumerator random_Bigmetal()
    {
        yield return new WaitForSeconds(4f);
        while (true)
        {
            for (int i = -1; i < 10; i++)
            {

                Vector3 vecd = new Vector3(Random.RandomRange(fizikgemi.position.x - 30, fizikgemi.position.x + 30), fizikgemi.position.y + 70, Random.RandomRange(fizikgemi.position.z -5, fizikgemi.position.z + 5));
                Instantiate(gameobject1, vecd, Quaternion.identity);
                yield return new WaitForSeconds(5f);

                Vector3 vece = new Vector3(Random.RandomRange(fizikgemi.position.x - 30, fizikgemi.position.x + 30), fizikgemi.position.y + 70, Random.RandomRange(fizikgemi.position.z - 5, fizikgemi.position.z + 5));
                Instantiate(gameobject2, vece, Quaternion.identity);
                yield return new WaitForSeconds(5f);
                Vector3 veca = new Vector3(Random.RandomRange(fizikgemi.position.x - 30, fizikgemi.position.x + 30), fizikgemi.position.y + 70, Random.RandomRange(fizikgemi.position.z - 5, fizikgemi.position.z + 5));
                Instantiate(gameobject3, veca, Quaternion.identity);
                yield return new WaitForSeconds(5f);
                i++;
            }
            yield return new WaitForSeconds(4f);

        }
    }
    void anamenu()
    {
        SceneManager.LoadScene("Anamenu");
    }
}