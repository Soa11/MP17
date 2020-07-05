using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_plane : MonoBehaviour
{

    public float  rotateSpeed;
    public float totalRotation =0;




    void Update()
    {
       
        // ...also rotate around the World's Y axis
        transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed , Space.World);
        //Debug.Log(Time.deltaTime * rotateSpeed);
        totalRotation += Time.deltaTime * rotateSpeed;

   
    
    }
}










