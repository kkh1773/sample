using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bb : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.transform.position;
        transform.position += new Vector3(0,0,0.1f);
        pos.z += 0.1f*Time.deltaTime;
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
