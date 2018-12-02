using UnityEngine;

public class Agriculture : IGodRole {

    God god;

    public void GoodAction() {
        UIManager.manager.CreateAlert("We are Blessed!", "Our harvest has gone spectacularly and we have gained much food!");
        GameManager.manager.PlaySound(0);
        GameManager.manager.resources.resourceList.Find(x => x.name == "Food").amount += (int)(GameManager.manager.fort.amountOfPeople * 0.15);
    }

    public void BadAction() {
        UIManager.manager.CreateAlert("Disaster!", "Much of our food has spontaniously rotted!");
        GameManager.manager.PlaySound(1);
        GameManager.manager.resources.resourceList.Find(x => x.name == "Food").amount -= (int)(GameManager.manager.fort.amountOfPeople * 0.5);
    }

    public void Sacrifice() {
        GameManager.manager.fort.amountOfPeople -= 5;
        GameManager.manager.fort.happiness -= 0.5f;
        god.happiness += 0.5f;
    }

    public void SetGod(God god) {
        this.god = god;
    }

}
