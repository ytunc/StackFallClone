using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Material darkMaterial;
    public Material whiteMaterial;


    public List<GameObject> Children;
       
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform)
        {
            Children.Add(child.gameObject);
        }
        SetMatarialAndTag();
        
    }
    void Update()
    {

    }
    
    void SetMatarialAndTag()
    {
        byte rnd = (byte)Random.Range(1, Children.Count);
      //  rnd = 0; // The all obstacle make white 
        for (int i = 0; i < rnd; i++)
        {
            Children[i].gameObject.GetComponent<Renderer>().sharedMaterial = darkMaterial;
            Children[i].gameObject.tag = "Enemy";
        }

        for (int i = rnd; i < Children.Count; i++)
        {
            Children[i].gameObject.GetComponent<Renderer>().sharedMaterial = whiteMaterial;
            Children[i].gameObject.tag = "Friend";
        }


    }

}
