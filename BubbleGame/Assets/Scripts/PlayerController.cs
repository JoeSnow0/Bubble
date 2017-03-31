using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Rotation
    public float rotationSpeed = 100.0F;
    float rotation;
    Quaternion playerRotZ;
    //Limit rotation to 180 degrees or less

    //Shooting
    float shootSpeed;
    //shooting should have cooldown
    //Shooting ball needs a color
    //
    

    void Start()
    {
        
    }
    void Update()
    {
        //Rotate Player(Arrow)
        
        rotation = Input.GetAxisRaw("Horizontal") * -rotationSpeed;
        rotation *= Time.deltaTime;
        transform.Rotate(0, 0, rotation);
        Debug.Log(GetComponent<Transform>().rotation.z);
        

        //Shooting


    }

}