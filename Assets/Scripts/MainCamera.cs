using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform target;

    [SerializeField]
    private float minY;
    [SerializeField]
    private float offset;


    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position.y - target.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (target.position.y < minY)
        {
            minY = target.position.y;
            transform.position = new Vector3(transform.position.x , minY + offset + 7f , transform.position.z);
        }
    }
}
