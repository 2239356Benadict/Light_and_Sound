using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCampStart : MonoBehaviour
{
    public ParticleSystem fireCampParticle;
    public GameObject[] gameObjectsToBeEnabled;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "FireSpark")
        {
            fireCampParticle.Play();
            gameObjectsToBeEnabled[0].SetActive(true);
            gameObjectsToBeEnabled[1].SetActive(true);
            gameObjectsToBeEnabled[2].SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
