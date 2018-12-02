using UnityEngine;

public class God {

    public string name;

    public float happiness;
    float happinessPerSecond;

    float wrathModifier;
    float wrathCutoff;
    
    public GodRole role;

    public God(string name, float happiness, float happinessPerSecond, float wrathModifier, float wrathCutoff, GodRole role) {
        this.name = name;
        this.happiness = happiness;
        this.happinessPerSecond = happinessPerSecond;
        this.wrathModifier = wrathModifier;
        this.wrathCutoff = wrathCutoff;
        this.role = role;
    }

    public void Update() {
        happiness += happinessPerSecond;

        Debug.Log(happiness);
        if (happiness < wrathCutoff && Random.value < wrathModifier) {
            Debug.Log("YOU HAVE ANGERED A GOD");
            role.BadAction();
        } else if (happiness > wrathCutoff && Random.value > wrathModifier) {
            Debug.Log("A god is pleased with you.");
            role.GoodAction();
        }
    }

}
