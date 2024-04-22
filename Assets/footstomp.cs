using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footstomp : MonoBehaviour
{
    // Start is called before the first frame update
    public float bounce;
    public Rigidbody2D rb2D;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("enemy"))
        {
            Destroy(other.gameObject);
            rb2D.velocity = new Vector2(rb2D.velocity.x, bounce);
        }
    }
}
