using UnityEngine;

public class Resource {

    string name;

    int amount;

    int amountPerSecond;
    
    public Resource(string name, int amount, int amountPerSecond) {
        this.name = name;
        this.amount = amount;
        this.amountPerSecond = amountPerSecond;
    }

    public void Update () {
        amount += amountPerSecond;
        Debug.Log(name + ": " + amount);
    }
}
