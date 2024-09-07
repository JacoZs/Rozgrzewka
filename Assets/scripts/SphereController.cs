using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SphereController : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 5f;
    [SerializeField]
    TMP_Text engameText;

    private void Start()
    {
        engameText.gameObject.SetActive(false);
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector3(horizontal * speed, 0f, vertical * speed);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "End")
        {
            engameText.gameObject.SetActive(true);
        }
    }
}
