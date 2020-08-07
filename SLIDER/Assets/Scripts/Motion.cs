using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    public float maxtime = 50;
    public float timer = 0;
    public GameObject block;
    GameObject newblock;
    public GameObject balls;

    // Start is called before the first frame update
    void Start()
    {
        newblock = Instantiate(block);
        newblock.transform.position = newblock.transform.position + new Vector3(5, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if(timer>maxtime)
        {
            GameObject newblockextra = Instantiate(newblock);
            newblockextra.transform.localScale = new Vector3(Random.Range(1,2), 1, 1);
            newblockextra.transform.position = newblock.transform.position + new Vector3(5,Random.Range(-2,4),0);
            
            Destroy(newblock, 40);
            timer = 0;
            newblock = newblockextra;
        }
        timer += Time.deltaTime;
    }
}
