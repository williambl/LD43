using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GodUIElement : MonoBehaviour {

    public Text label;
    public Button sacrificeButton;

    God god;

    public void ChangeLabel (string newLabel) {
        label.text = newLabel;
        sacrificeButton.onClick.AddListener(Sacrifice);
    }

    public void Sacrifice() {
        god.Sacrifice();
    }

    public void SetGod(God god) {
        this.god = god;
    }
}
