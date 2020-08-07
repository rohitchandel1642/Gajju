using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BALL : MonoBehaviour
{
    public float velocity = 1;
    public Rigidbody rj;
    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = new Vector3(rj.transform.position.x, rj.transform.position.y, transform.position.z);  

    }
}
