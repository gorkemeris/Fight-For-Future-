using System.Collections;

using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    Rigidbody fizik;
    Rigidbody trash_fizik;
    Rigidbody bullet_fizik;
    Rigidbody rocket_fizik;
    Rigidbody bullet_rocket_f;
    Rigidbody particle_f;

    GameObject bullet;
    GameObject trash;
    GameObject bullet_rocket;
   
    
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject e;
    public GameObject f;
    public GameObject g;
    public GameObject h;
    public GameObject l;
    public GameObject j;
    public GameObject exx;

    public GameObject particle;

    
    public Vector3 randomPos;

    Vector3 vec;
    Vector3 bullet_vec;
    Vector3 vect;

    public float hiz;
    public float egim_z;
    public float egim_x;

    float horizontal = 0;
    float vertical = 0;
    float speed = 0.5f;
    float times = 0;
    float ates_zamani = 0.05f;
    int t = 0;
    float rocket_ates_zamani;
    float gerileme_zamani = 0.05f;
    float bullet_time;
    public int thrash_hiz;


    void Start()

    {
        
       
        bullet = GameObject.FindGameObjectWithTag("bullet");
        bullet_fizik = bullet.GetComponent<Rigidbody>();
        bullet_rocket = GameObject.FindGameObjectWithTag("b_rocket");
        bullet_rocket_f = bullet_rocket.GetComponent<Rigidbody>();
        particle_f = particle.GetComponent<Rigidbody>();

        
        trash = GameObject.FindGameObjectWithTag("trash");



        trash_fizik = trash.GetComponent<Rigidbody>();
        StartCoroutine(random_trashes());
        fizik = GetComponent<Rigidbody>();

        trash_fizik.angularVelocity = Random.insideUnitSphere * thrash_hiz;
       


    }

    // Update is called once per frame
    void Update()
    {
        //For space ship
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        vec = new Vector3(-horizontal, speed, -vertical);
        fizik.velocity = vec * hiz;
        rotation_rocket();
        shipMovement();
        //----------------------------------------------------------------------------------------
        

        //For bullet

        //----------------------------------------------------------------------------------------

        //missile
        missile();
        //---------------------------------------
        
        
    }

    void rotation_rocket()
    {
        fizik.rotation = Quaternion.Euler(fizik.velocity.z * egim_x, 0, fizik.velocity.x * egim_z);

    }
    
    void shipMovement()

    {

        if (Input.GetButton("Fire2") == true && ates_zamani < Time.time && hiz < 23)

        {
            ates_zamani = Time.time + 0.05f;
            hiz = hiz += 0.3f;


        }



        else if (Input.GetButton("Fire2") == false && gerileme_zamani < Time.time && hiz > 10)
        {



            gerileme_zamani = Time.time + 0.05f;
            hiz = hiz -= 0.3f;


        }
    }

    IEnumerator random_trashes()
    {
        
        yield return new WaitForSeconds(0.7f);
        while (true)
        {

            for (int i = 0; i < 15; i++)
            {
                Vector3 vecd = new Vector3(Random.RandomRange(fizik.position.x-40, fizik.position.x + 40), + fizik.position.y + 30, Random.RandomRange(fizik.position.z - 40, fizik.position.z + 40));
                
                Instantiate(b, vecd, Quaternion.identity);
                yield return new WaitForSeconds(0.13f);
                Vector3 vec5 = new Vector3(Random.RandomRange(fizik.position.x - 40, fizik.position.x + 40), +fizik.position.y + 30, Random.RandomRange(fizik.position.z - 40, fizik.position.z + 40));
                Instantiate(c, vec5, Quaternion.identity);
                yield return new WaitForSeconds(0.13f);
                Vector3 vec6 = new Vector3(Random.RandomRange(fizik.position.x - 40, fizik.position.x + 40), +fizik.position.y + 30, Random.RandomRange(fizik.position.z - 40, fizik.position.z + 40));
                Instantiate(d, vec6, Quaternion.identity);
                yield return new WaitForSeconds(0.13f);
                Vector3 vec7 = new Vector3(Random.RandomRange(fizik.position.x - 40, fizik.position.x + 40), +fizik.position.y + 30, Random.RandomRange(fizik.position.z - 40, fizik.position.z + 40));
                Instantiate(e, vec7, Quaternion.identity);
                yield return new WaitForSeconds(0.13f);
                Vector3 vec8 = new Vector3(Random.RandomRange(fizik.position.x - 40, fizik.position.x + 40), +fizik.position.y + 30, Random.RandomRange(fizik.position.z - 40, fizik.position.z + 40));
                Instantiate(f, vec8, Quaternion.identity);
                yield return new WaitForSeconds(0.13f);
                Vector3 vec9 = new Vector3(Random.RandomRange(fizik.position.x - 40, fizik.position.x + 40), +fizik.position.y + 30, Random.RandomRange(fizik.position.z - 40, fizik.position.z + 40));
                Instantiate(g, vec9, Quaternion.identity);
                yield return new WaitForSeconds(0.13f);
                Vector3 veca = new Vector3(Random.RandomRange(fizik.position.x - 40, fizik.position.x + 40), +fizik.position.y + 30, Random.RandomRange(fizik.position.z - 40, fizik.position.z + 40));
                Instantiate(h, veca, Quaternion.identity);
                yield return new WaitForSeconds(0.13f);
                Vector3 vecb = new Vector3(Random.RandomRange(fizik.position.x - 40, fizik.position.x + 40), +fizik.position.y + 30, Random.RandomRange(fizik.position.z - 40, fizik.position.z + 40));
                Instantiate(l, vecb, Quaternion.identity);
                yield return new WaitForSeconds(0.13f);
                Vector3 vecc = new Vector3(Random.RandomRange(fizik.position.x - 40, fizik.position.x + 40), +fizik.position.y + 30, Random.RandomRange(fizik.position.z - 40, fizik.position.z + 40));
                Instantiate(j, vecc, Quaternion.identity);
                yield return new WaitForSeconds(0.13f);
                

                i++;
            }
            yield return new WaitForSeconds(0.5f);

        }
    }

    /* void bullet_mov()

     {

         if (Input.GetButton("Fire1") == true && bullet_time < Time.time)

         {

             Instantiate(bullet, Input.mousePosition, Quaternion.identity);
             bullet_time = Time.time + 0.7f;



         }


     }
     */

    void missile()
    {
        if (Input.GetButton("Fire1") == true && rocket_ates_zamani<Time.time)

        {
            
            Vector3 r_vec = new Vector3(transform.position.x , transform.position.y , transform.position.z);
            Instantiate(bullet_rocket,r_vec,Quaternion.identity);
            

            rocket_ates_zamani = Time.time + 2;

        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "trash")
        {
            Instantiate(exx, fizik.position, Quaternion.identity);
        }
    }

}

