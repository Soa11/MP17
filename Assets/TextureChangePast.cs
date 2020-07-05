using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureChangePast : MonoBehaviour
{

    public Material PastMat;
    //Array of textures
    public Texture[] array;
    //index by which we access array
    int index = 0;

    //Working timer variable
    float timer = 0;
    //Timer threshold variable - set via inspector
    public float timerMax;
    //reference variable to object renderer
    new Renderer renderer;



    // Start is called before the first frame update
    void Start()
    {
        PastMat.SetTexture("_TexturePast", array[index]);

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timerMax)
        {
            timer = 0;
            Debug.Log(array[index]);
            PastMat.SetTexture("_TexturePast", array[index]);
            //renderer.material.SetTexture("_BaseColorMap", array[index]);
            index += 1;
            //index++;
            //index++;
            // print(index);

            if (index == 50 )
            {
                index = 0;
            }


        }
    }
}
