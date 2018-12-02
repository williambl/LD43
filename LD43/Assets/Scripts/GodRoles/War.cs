using UnityEngine;

public class War : IGodRole {

    God god;

    public void GoodAction() {
        Debug.Log("Repairing Fort");
        UIManager.manager.CreateAlert("We are blessed!", "Our fort walls have been strengthened by our War God!");
        GameManager.manager.fort.health += 0.1f;
    }

    public void BadAction() {
        UIManager.manager.CreateAlert("Disaster!", "The enemies' attacks have increased in strength! They must have divine favour!");
        GameManager.manager.enemies.damageBase += 5;
    }

    public void Sacrifice() {
        GameManager.manager.resources.resourceList.Find(x => x.name == "Food").amount -= 10;
        god.happiness += 0.5f;
    }

    public void SetGod(God god) {
        this.god = god;
    }
}
