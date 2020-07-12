using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderTextureChange : MonoBehaviour
{
    //Working timer variable
    float timer = 0;
    //Timer threshold variable - set via inspector
    public float timerMax;

    public Material FutureMat;

    public Material PastMat;

    //Array of textures
    public Texture[] Futurearray;
    public Texture[] Pastarray;

    //index by which we access array
    int index = 0;

    string playerPrefsTextureIndex = "Texture Index";


    void Start()
    {
        //Retrieve Index from playerprefs, and use it
        index = PlayerPrefs.GetInt(playerPrefsTextureIndex);
        Debug.Log("Loaded Index " + index);


        FutureMat.SetTexture("_TextureFuture", Futurearray[index]);
        PastMat.SetTexture("_TexturePast", Pastarray[index]);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > timerMax)
        {
            timer = 0;
            
            FutureMat.SetTexture("_TextureFuture", Futurearray[index]);
            PastMat.SetTexture("_TexturePast", Pastarray[index]);

            //Change Index
            index += 1;
            if (index == 50)
            {
                index = 0;
            }

            //Save Index to playerprefs
            PlayerPrefs.SetInt(playerPrefsTextureIndex, index);
        }
    }
}
