﻿using UnityEngine;
using System.Collections;

public class LoadStartScene : MonoBehaviour
{
    public int timeToComplete = 2;
 
    // Use this for initialization
    void Update () {
        //Use this to Start progress
            StartCoroutine(RadialProgress(timeToComplete));
    }
 
    IEnumerator RadialProgress(float time)
    {
        float rate = 1 / time;
        float i = 0;
        while (i < 1)
        {
            i += Time.deltaTime * rate;
            gameObject.GetComponent<Renderer>().material.SetFloat("_Cutoff", i);
            yield return 0;
        }
    }
}
