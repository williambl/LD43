using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberUIElement : MonoBehaviour {

    public Text label;
    public Image background;

    public Gradient gradient;

    public void ChangeLabelAndBackground (string newLabel, float backgroundColour) {
        label.text = newLabel;
        background.color = gradient.Evaluate(backgroundColour);
    }
}
