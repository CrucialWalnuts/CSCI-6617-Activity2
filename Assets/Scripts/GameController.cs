using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public Text winText;
    public int totalSpheres = 5;
    private int collectedSpheres = 0;
    // Start is called before the first frame update
    void Start()
    {
        //winText.gameObject.SetActive(false);
    }
    public void SphereCollected()
    {
        collectedSpheres++;
        if (collectedSpheres == totalSpheres)
        {
            //winText.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
