using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureChangeFuture : MonoBehaviour
{
    //Working timer variable
    float timer = 0;
    //Timer threshold variable - set via inspector
    public float timerMax;

    public Material FutureMat;
    //Array of textures
    public Texture[] array;
    //index by which we access array
    int index = 0;

   
    // Start is called before the first frame update
    void Start()
    {
        FutureMat.SetTexture("_TextureFuture", array[index]);

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timerMax)
        {
            timer = 0;
            
            FutureMat.SetTexture("_TextureFuture", array[index]);
            Debug.Log(array[index]);
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
