using UnityEngine;

public class God {

    string name;

    float happiness;
    float happinessPerSecond;

    float wrathModifier;
    float wrathCutoff;
    
    GodRole role;

    public God(string name, float happiness, float happinessPerSecond, float wrathModifier, float wrathCutoff) {
        this.name = name;
        this.happiness = happiness;
        this.happinessPerSecond = happinessPerSecond;
        this.wrathModifier = wrathModifier;
        this.wrathCutoff = wrathCutoff;
    }

    void Update() {
        happiness += happinessPerSecond;

        if (happiness < wrathCutoff && Random.value < wrathModifier) {
            role.BadAction();
        } else if (happiness > wrathCutoff && Random.value > wrathModifier) {
            role.GoodAction();
        }
    }

}
