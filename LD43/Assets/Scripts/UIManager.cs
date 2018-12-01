using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    public GameObject numberPrefab;
    public Transform canvasTransform;

    int lastPosition = 0;

    public static UIManager manager;

    void Awake () {
        manager = this;
    }

    public GameObject GetUIText() {
        var gObject = Instantiate(numberPrefab, canvasTransform);
        lastPosition -= 50;
        gObject.transform.position -= Vector3.down * lastPosition;

        return gObject;
    }

}
