using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {

    public Transform[] points;
    int currentPoint = 0;
    
    Vector3 velocity = Vector3.zero;
    Vector3 angularVelocity = Vector3.zero;
    float smoothTime = 0.3f;

    void Start () {
        
    }

    void Update () {
        if (Input.GetButtonDown("Jump")) {
            currentPoint++;
        }

        if (currentPoint >= points.Length) {
            SceneManager.LoadScene(1);
            return;
        }

        transform.position = Vector3.SmoothDamp(transform.position, points[currentPoint].position, ref velocity, smoothTime);
        transform.eulerAngles = Vector3.SmoothDamp(transform.eulerAngles, points[currentPoint].eulerAngles, ref angularVelocity, smoothTime);
    }
}
