using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlertUIElement : MonoBehaviour {

    public Text title;
    public Text body;
    public Button close;

    void Start () {
        close.onClick.AddListener(Close);
    }

    public void SetContents(string titleText, string bodyText) {
        title.text = titleText;
        body.text = bodyText;
    }

    public void Close () {
        Destroy(gameObject);
    }
}
