using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleMouse : MonoBehaviour
{
    public GameObject Zombie;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
    }

    void Update()
    {
        if (Input.GetKey("space") || Input.GetKey("return"))
        {
            Zombie.SetActive(true);
            this.gameObject.SetActive(false);
        }
        
    }
}
