using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind_side : MonoBehaviour
{
    public float windforce = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name);
        other.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * windforce);

        Vector2 left = new Vector2(-1, 0);
    }
}
