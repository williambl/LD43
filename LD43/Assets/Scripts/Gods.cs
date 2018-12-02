using System.Collections.Generic;

public class Gods {

    public List<God> godList = new List<God>();
    public List<GodRole> godRoleList;

    public Gods() {
        AddGods();    
    }

    void AddGods() {
        godList.Add(new God("Agriculture God", 1, -0.01f, 0.4f, 0.6f, new Agriculture("Agriculture")));
    }

    public void Update() {
        foreach (God god in godList) {
            god.Update();
        }
    }
}
