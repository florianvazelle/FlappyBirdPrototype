using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour {

    public float velocity = 3;
    private Rigidbody2D colBird;

    public Manager gameManager;

    void Start() {
        colBird = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            colBird.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        gameManager.GameOver();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Score.score++;
    }
}
