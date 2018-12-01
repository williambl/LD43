using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    public GameObject numberPrefab;
    public Transform canvasTransform;

    public static UIManager manager;

    void Awake () {
        manager = this;
    }

    public GameObject GetUIText() {
        return Instantiate(numberPrefab, canvasTransform);
    }

}
