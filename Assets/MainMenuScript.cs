using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public AudioSource a; // audio source we use for plaeing sound :D
    public AudioClip c; // one of our audio clips
    public AudioClip cc; // our second audio clip

    public void b() // function for button pressing action :D
    {
        switch ((int)Random.Range(1, 3)) 
        {
            case 1: a.PlayOneShot(c); break;
            case 2: a.PlayOneShot(cc); break;
            case 0: break; // there is no case zero
            default: Debug.Log("Happy warning! :D");break;
        }

        Invoke("s", 3);

    }
    public void s() // switches our scene :D 
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
