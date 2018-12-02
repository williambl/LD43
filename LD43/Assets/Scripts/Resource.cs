using UnityEngine;
using UnityEngine.UI;

public class Resource {

    public string name;

    public int amount;

    int amountPerSecond;

    NumberUIElement uiElement;
    
    public Resource(string name, int amount, int amountPerSecond) {
        this.name = name;
        this.amount = amount;
        this.amountPerSecond = amountPerSecond;
        uiElement = UIManager.manager.GetUIText().GetComponent<NumberUIElement>();
    }

    public void Update () {
        amount += amountPerSecond;
        uiElement.ChangeLabel(name + ": " + amount);
    }
}
