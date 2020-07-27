using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrip : MonoBehaviour
{
    public float velocity = 1;
    private Rigidbody sn;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        sn = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sn.velocity = Vector2.up * velocity;
            
        }
        sn.transform.position += new Vector3(sn.transform.position.x * speed * Time.deltaTime, 0, 0);
    }
}
