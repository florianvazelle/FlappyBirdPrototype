using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    
    void Update() {
        transform.position += Vector3.left * Time.deltaTime;
    }
}
