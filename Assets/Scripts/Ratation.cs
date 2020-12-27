using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ratation : MonoBehaviour
{
    public int rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed, Space.Self);

    }
}
