using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    float speed = 3f;
    private GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        Vector3 pos = this.transform.position;
        pos.x += x * Time.deltaTime * speed;
        pos.z += z * Time.deltaTime * speed;
        
        transform.position = pos;
        this.GetComponent<Rigidbody>().velocity=Vector3.zero;

    }

    
}
