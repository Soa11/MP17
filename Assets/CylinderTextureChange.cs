﻿using System.Collections;
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


    // Start is called before the first frame update
    void Start()
    {
        FutureMat.SetTexture("_TextureFuture", Futurearray[index]);
        PastMat.SetTexture("_TexturePast", Pastarray[index]);
    }

    // Update is called once per frame
    void Update()
    {

        //RotateCylinder rotate = GetComponent<RotateCylinder>();
        //Debug.Log(rotate.totalRotation);

        /*if (rotate.totalRotation > 360)
        {

            rotate.totalRotation -= 360;

            index += 1;
            FutureMat.SetTexture("_TextureFuture", Futurearray[index]);
            PastMat.SetTexture("_TexturePast", Pastarray[index]);

            // index += 1;

            if (index == 50)
            {
                index = 0;
            }


            //Debug.Log(rotate.totalRotation);
        }*/


        timer += Time.deltaTime;
        Debug.Log(timer);

        if (timer > timerMax)
        {
            timer = 0;
            
            FutureMat.SetTexture("_TextureFuture", Futurearray[index]);
            PastMat.SetTexture("_TexturePast", Pastarray[index]);
            //Debug.Log(array[index]);
            index += 1;
            //index++;
            //index++;
           

            if (index == 50)
            {
                index = 0;
            }
            
        }
    }
}
