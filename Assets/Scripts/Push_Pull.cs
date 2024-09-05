using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push_Pull : MonoBehaviour
{
    public float force = 10f;
    private Rigidbody2D rb2d;
    private Camera cam;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);
            if (hit.collider != null)
            {
                Vector2 direction = (mousePos - (Vector2)hit.collider.transform.position).normalized;
                hit.rigidbody.AddForce(direction * force);
            }
        }
    }
}


//Cite by ChatGPT https://chatgpt.com/