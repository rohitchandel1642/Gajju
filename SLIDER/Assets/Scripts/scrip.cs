using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrip : MonoBehaviour
{
    public float velocity = 5;
    private Rigidbody sn;
    public float speed;
    public float acceleration = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        sn = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        
        sn.transform.position += new Vector3(speed * Time.deltaTime * acceleration, 0, 0);
        sn.transform.Rotate(5, 5, 5);
        acceleration += 0.001f;
        
    }

    private void OnCollisionStay(Collision col)
    {
        if(col.gameObject.tag == "ground" && Input.GetMouseButtonDown(0))
        {
            
                sn.velocity = Vector2.up * velocity;
                Debug.Log("simran");
           
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ground" && Input.GetMouseButtonDown(0))
        {

            sn.velocity = Vector2.up * velocity;
            Debug.Log("simran");

        }
    }
    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "ground" && Input.GetMouseButtonDown(0))
        {

            sn.velocity = Vector2.up * velocity;
            Debug.Log("simran");

        }
    }
}
