using System.Collections.Generic;

public class Gods {

    public List<God> godList = new List<God>();

    public Gods() {
        AddGods();    
    }

    void AddGods() {
        godList.Add(new God("Agriculture God", 1, -0.01f, 0.8f, 0.6f, new Agriculture()));
        godList.Add(new God("War God", 1, -0.01f, 0.8f, 0.6f, new War()));
    }

    public void Update() {
        foreach (God god in godList) {
            god.Update();
        }
    }
}
