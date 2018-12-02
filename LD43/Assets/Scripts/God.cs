using UnityEngine;

public class God {

    public string name;

    public float happiness;
    float happinessPerSecond;

    float wrathModifier;
    float wrathCutoff;
    
    public IGodRole role;

    GodUIElement uiElement;

    public God(string name, float happiness, float happinessPerSecond, float wrathModifier, float wrathCutoff, IGodRole role) {
        this.name = name;
        this.happiness = happiness;
        this.happinessPerSecond = happinessPerSecond;
        this.wrathModifier = wrathModifier;
        this.wrathCutoff = wrathCutoff;
        this.role = role;

        uiElement = UIManager.manager.CreateGodUIElement();
        
        uiElement.SetGod(this);
        this.role.SetGod(this);
    }

    public void Update() {
        happiness += happinessPerSecond * Random.Range(0.5f, 2.5f);

        if (happiness < wrathCutoff && Random.value+0.1 > wrathModifier) {
            role.BadAction();
        } else if (happiness > wrathCutoff && Random.value > wrathModifier) {
            role.GoodAction();
        }

        uiElement.ChangeLabelAndBackground(name, happiness);
    }

    public void Sacrifice() {
        role.Sacrifice();
    }

}
