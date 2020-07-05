using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_plane : MonoBehaviour
{

    public float  rotateSpeed;

    void Update()
    {
       
        // ...also rotate around the World's Y axis
        transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed , Space.World);


    }
}










