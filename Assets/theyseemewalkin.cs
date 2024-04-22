using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class theyseemewalkin : MonoBehaviour
{
    public float walkspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            transform.position = new Vector3(walkspeed, 0, 0) * Time.deltaTime;
        if (transform.position.x < 0)
        {
            transform.position = new Vector3(walkspeed * -1, 0, 0) * Time.deltaTime;
        }
    }
    
}
