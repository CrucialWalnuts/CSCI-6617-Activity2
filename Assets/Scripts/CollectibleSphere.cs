using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSphere : MonoBehaviour
{
    public GameController gameController;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player")
        {
            //gameController.SphereCollected(); 
            Destroy(gameObject);
        }
    }
}