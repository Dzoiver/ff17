﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CryptDir : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab;
    [SerializeField] GameObject image;
    [SerializeField] GameObject playerObject;
    void Start()
    {
        Playerscript.instance.lastMap = "Crypt";
        Playerscript.instance.allowControl = false;
        playerPrefab.transform.position = Finfor.startVector;
        StartCoroutine(waitTime());
        CameraScript.instance.FindPlayer(playerObject);
    }

    IEnumerator waitTime()
    {
        FadeBlack script = image.GetComponent<FadeBlack>();
        script.FadeOut(1f);
        yield return new WaitForSeconds(1f);
        Playerscript.instance.allowControl = true;
    }
}
