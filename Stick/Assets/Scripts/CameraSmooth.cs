using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSmooth : MonoBehaviour
{
    private Vector3 Offset;

    private float smoothTime=0.25f;

    private Vector3 Velocity;

     public Transform Target;



    // Start is called before the first frame update
    void Start()
    {


        

        Offset= new Vector3(0,0,-10f);

        Velocity = new Vector3();
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 Target_Position = Target.position + Offset;
        
        
      transform.position = Vector3.SmoothDamp(transform.position,Target_Position,ref Velocity,smoothTime);


       
        
    }
}
