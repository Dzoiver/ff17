﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CryptDir : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject image;
    // Start is called before the first frame update
    void Start()
    {
        Playerscript.lastMap = "Crypt";
        Playerscript.allowControl = false;
        StartCoroutine(waitTime());
        // allyListPrefab.Add(player);
        // for (int i = 0; i < allyListPrefab.Count; i++)
        // {
        //     Debug.Log("creating player objects");
        //     // atbList.Add(new ATB(){ Amount = 0f, IsEnemy=true});
        //     CharBat charact = new CharBat();
        //     charact.atb = new ATB(){ Amount = 0f};
        //     charact.IsEnemy = false;
        //     charact.prefabObj = allyListPrefab[i];
        //     charact.instanceObj = Instantiate(charact.prefabObj);
        //     // charact.atb = new ATB(){ Amount = 0f, IsEnemy=false};

        //     allyListObject.Add(charact);
        // }
    }

    IEnumerator waitTime()
    {
        FadeBlack script = image.GetComponent<FadeBlack>();
        script.FadeOut(1f);
        yield return new WaitForSeconds(1f);
        Playerscript.allowControl = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
