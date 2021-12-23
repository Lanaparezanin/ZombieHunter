/* Special thanks to jiankaiwang for writing this script!!!*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2 : MonoBehaviour
{
    public float speed = 10.0f;
    private float translation;
    private float straffe;
    private float straffeZero = 0f;
    private float translationZero = 0f;
    //public AudioSource audio2;

    // Use this for initialization
    void Start()
    {
        // turn off the cursor
        Cursor.lockState = CursorLockMode.Locked;
        //audio2 = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Input.GetAxis() is used to get the user's input
        // You can furthor set it on Unity. (Edit, Project Settings, Input)
        translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        straffe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown("escape"))
        {
            // turn on the cursor
            Cursor.lockState = CursorLockMode.None;
        }

        //following function checks if player moving, to play sound of running
        //if(straffeZero!=straffe || translationZero != translation)
        //{
            
            //audio2.PlayOneShot(Resources.Load<AudioClip>("Sounds/running"));
        //}

        straffeZero = straffe;
        translationZero = translation;
    }
}
