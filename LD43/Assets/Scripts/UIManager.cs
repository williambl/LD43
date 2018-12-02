using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public GameObject numberPrefab;
    public GameObject godPrefab;
    public GameObject alertPrefab;

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

    public GodUIElement CreateGodUIElement() {
        var gObject = Instantiate(godPrefab, canvasTransform);
        lastPosition -= 50;
        gObject.transform.position -= Vector3.down * lastPosition;

        return gObject.GetComponent<GodUIElement>();
    }

    public void CreateAlert(string title, string body) {
        var gObject = Instantiate(alertPrefab, canvasTransform);
        gObject.GetComponent<AlertUIElement>().SetContents(title, body);
    }

    public void Lose(string reason) {
        CreateAlert("Defeat!", "We have lost because "+reason);
    }
}
