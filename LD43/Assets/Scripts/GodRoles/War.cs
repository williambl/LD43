using UnityEngine;

public class War : IGodRole {

    public void GoodAction() {
        Debug.Log("Repairing Fort");
        GameManager.manager.fort.health += 0.1f;
    }

    public void BadAction() {
        Debug.Log("Increasing Enemy Strength");
        GameManager.manager.enemies.damageBase += 5;
    }

}
