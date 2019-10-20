using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ANAmenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()

    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void oyunaGit()

    {
        SceneManager.LoadScene("SampleScene");
    }


    public void oyundanCik()
    {
        Application.Quit();
    }
}
