using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerBehaviour : MonoBehaviour {

    Rigidbody2D rb;
    [SerializeField]
    float speed;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update() {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed;
    }
}
