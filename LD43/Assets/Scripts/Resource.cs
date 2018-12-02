using UnityEngine;
using UnityEngine.UI;

public class Resource {

    public string name;

    public int amount;

    int amountPerSecond;

    Text uiText;
    
    public Resource(string name, int amount, int amountPerSecond) {
        this.name = name;
        this.amount = amount;
        this.amountPerSecond = amountPerSecond;
        uiText = UIManager.manager.GetUIText().GetComponent<Text>();
    }

    public void Update () {
        amount += amountPerSecond;
        uiText.text = name + ": " + amount;
    }
}
