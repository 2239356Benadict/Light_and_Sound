// This script is to check the colliding object and to enable some light for the fire effect.
// Tested in unity editor and Oculus Quest
// Copyright (c) 2239356@swanseauniversity. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
// Dated: 05/12/2020

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCampStart : MonoBehaviour
{
    public ParticleSystem fireCampParticle;
    public GameObject[] gameObjectsToBeEnabled;

    /// <summary>
    /// Method to enable gameobjects
    /// </summary>
    /// <param name="other"></param>
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

}
