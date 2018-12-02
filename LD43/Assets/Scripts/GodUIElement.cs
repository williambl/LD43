using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GodUIElement : MonoBehaviour {

    public Text label;
    public Button sacrificeButton;
    public Image background;

    public Gradient gradient;

    God god;

    void Start() {
        sacrificeButton.onClick.AddListener(Sacrifice);
    }

    public void ChangeLabelAndBackground (string newLabel, float backgroundColour) {
        label.text = newLabel;
        background.color = gradient.Evaluate(backgroundColour);
    }

    public void Sacrifice() {
        god.Sacrifice();
    }

    public void SetGod(God god) {
        this.god = god;
    }
}
