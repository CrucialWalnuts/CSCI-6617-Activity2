using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public Text winText;
    public int totalSpheres = 5;
    private int collectedSpheres = 0;
    public AudioSource winAudio;
    public AudioSource collectAudio;
    // Start is called before the first frame update
    void Start()
    {
        winText = GameObject.FindWithTag("WinMessage").GetComponent<Text>();
        winText.text = String.Format("You have collected {0}/{1} spheres", collectedSpheres, totalSpheres);
    }
    
    public void SphereCollected()
    {
        //Debug.Log("Sphere collected");
       
        collectedSpheres++;
        winText.text = String.Format("You have collected {0}/{1} spheres", collectedSpheres, totalSpheres);
        collectAudio.Play();

        if (collectedSpheres == totalSpheres)
        {
             winText.text = String.Format("Congratulations! You have collected all spheres");
             winAudio.PlayDelayed(1.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
