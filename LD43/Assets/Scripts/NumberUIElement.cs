using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberUIElement : MonoBehaviour {

    public Text label;

    public void ChangeLabel (string newLabel) {
        label.text = newLabel;
    }
}
