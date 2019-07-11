using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public float maxTimer = 3.5f;
    private float timer = 0;
    public GameObject pipe;
    public float height = 2;

    void Update() {
        if(timer > maxTimer) {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 8);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
