public class Agriculture : GodRole {

    public Agriculture(string name) : base(name) {}

    public void GoodAction() {
        GameManager.manager.resources.resourceList.Find(x => x.name == "Food").amount += (GameManager.manager.fort.amountOfPeople * 2);
    }

    public void BadAction() {
        GameManager.manager.resources.resourceList.Find(x => x.name == "Food").amount -= (int)(GameManager.manager.fort.amountOfPeople * 0.5);
    }

}
