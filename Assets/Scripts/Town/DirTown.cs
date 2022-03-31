﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CharactersInBattle;
using Positions;

public class DirTown : MonoBehaviour
{
    public GameObject destinationPoint;
    public GameObject image;
    // Start is called before the first frame update
    void Start()
    {
        if (Playerscript.lastMap == "WM")
        {
            Playerscript.allowControl = false;
            StartCoroutine(waitTimeAfterWM());
            GameObject.FindWithTag("Player").transform.position = destinationPoint.transform.position;
        }
        else
        {
            Playerscript.allowControl = false;
            StartCoroutine(waitTime());
        }
        Playerscript.lastMap = "Town";
    }

    IEnumerator waitTimeAfterWM()
    {
        FadeBlack script = image.GetComponent<FadeBlack>();
        script.FadeOut(1f);
        yield return new WaitForSeconds(1f);
        Playerscript.allowControl = true;
    }

    IEnumerator waitTime()
    {
        FadeBlack script = image.GetComponent<FadeBlack>();
        script.FadeOut(3f);
        yield return new WaitForSeconds(4f);
        Playerscript.allowControl = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
