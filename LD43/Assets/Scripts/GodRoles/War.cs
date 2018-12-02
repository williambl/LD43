using UnityEngine;

public class War : IGodRole {

    God god;

    public void GoodAction() {
        Debug.Log("Repairing Fort");
        GameManager.manager.fort.health += 0.1f;
    }

    public void BadAction() {
        Debug.Log("Increasing Enemy Strength");
        GameManager.manager.enemies.damageBase += 5;
    }

    public void Sacrifice() {
        GameManager.manager.resources.resourceList.Find(x => x.name == "Food").amount -= 100;
        god.happiness += 0.5f;
    }

    public void SetGod(God god) {
        this.god = god;
    }
}
