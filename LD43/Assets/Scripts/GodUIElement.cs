using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GodUIElement : MonoBehaviour {

    public Text label;
    public Button sacrificeButton;

    public void ChangeLabel (string newLabel) {
        label.text = newLabel;
    }
}
