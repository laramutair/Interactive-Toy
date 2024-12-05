using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheCar : MonoBehaviour
{
    public float speed=0.5f;
    
    void Update()
    {
      Vector3 position=transform.position;

        if(Input.GetKey(KeyCode.UpArrow))
         {
           position+=new Vector3(speed,0, 0);
         }
         else if (Input.GetKey(KeyCode.DownArrow))
         {
          position-=new Vector3(speed,0, 0);
         }
          else if (Input.GetKey(KeyCode.RightArrow))
         {
          position-=new Vector3(0,0,speed);
         }
          else if (Input.GetKey(KeyCode.LeftArrow))
         {
          position-=new Vector3(0,0,-speed);
         }
         
          position.x=Mathf.Clamp(position.x,-50,355);
          position.z=Mathf.Clamp(position.z,86,120);
          transform.position=position;

    }

}
