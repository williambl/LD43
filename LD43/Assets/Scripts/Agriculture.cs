using UnityEngine;

public class Agriculture : IGodRole {

    public void GoodAction() {
        Debug.Log("Adding food");
        GameManager.manager.resources.resourceList.Find(x => x.name == "Food").amount += (GameManager.manager.fort.amountOfPeople * 2);
    }

    public void BadAction() {
        GameManager.manager.resources.resourceList.Find(x => x.name == "Food").amount -= (int)(GameManager.manager.fort.amountOfPeople * 0.5);
    }

}
