using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plater : MonoBehaviour
{
    public GameObject bb;
    private float ss = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (ss >= 0.2)
            {
                Instantiate(bb);
                ss = 0;
            }
            ss += Time.deltaTime;
        }
    }
}
