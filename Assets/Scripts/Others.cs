using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Others : MonoBehaviour
{
    public float speed=0.5f;
    void Update()
    {
        Vector3 position=transform.position;
        position+=new Vector3(speed,0f,0f);
        
        position.x=Mathf.Clamp(position.x,-30,355);
        transform.position=position;

        
    }
}
