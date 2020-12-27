using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public bool contact;
    public int jumpForce, downForce;

    public GameObject UI;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            contact = true;
            jumpForce = 0;
        }
        if (Input.GetMouseButtonUp(0))
        {
            contact = false;
            jumpForce = 6;
        }
        if (contact)
        {
            rb.velocity = Vector3.up * -downForce;
        }

    }

    private void FixedUpdate()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (contact)
        {
            if (collision.gameObject.tag =="Enemy")
            {
                SceneManager.LoadScene(0);
            }
            else if (collision.gameObject.CompareTag("Friend"))
            {
                Destroy(collision.transform.parent.gameObject);
                UI.GetComponent<UI>().SliderUp();
            }
            else if (collision.gameObject.tag == "Finish")
            {
                PlayerPrefs.SetInt("level", +1);
                Debug.Log("Win");
                jumpForce = 0;
                downForce = 0;
            }
        }

        rb.velocity = Vector3.up * jumpForce;
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Friend")
        {
            Debug.Log("stay on obstacle");
            rb.velocity = Vector3.up * jumpForce;
        }
    }


}
