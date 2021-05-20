using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
