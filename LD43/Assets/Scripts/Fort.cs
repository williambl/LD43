using UnityEngine;
using UnityEngine.UI;

public class Fort {

    public float happiness;
    Text happinessUI;

    public int amountOfPeople;
    Text populationUI;

    public float health;
    Text healthUI;

    float happinessPerSecond;
    int secondsPerPeople;

    public Fort() {
        happiness = 0.5f;
        amountOfPeople = 500;
        health = 1.0f;
        happinessPerSecond = -0.01f;
        secondsPerPeople = 5;

        happinessUI = UIManager.manager.GetUIText().GetComponent<Text>();
        populationUI = UIManager.manager.GetUIText().GetComponent<Text>();
        healthUI = UIManager.manager.GetUIText().GetComponent<Text>();
    }

    public void Update() {
        happiness += happinessPerSecond;

        if (((int)Time.time % secondsPerPeople) == 0)
            amountOfPeople++;

        happinessUI.text ="Happiness: " + happiness;
        populationUI.text ="People: " + amountOfPeople;
        healthUI.text ="Health: " + health;
    }

    public void DoDamage(float damage) {
        if (damage > 20)
            amountOfPeople -= Random.Range(1, 75);
        
        health -= damage/(GameManager.manager.enemies.damageBase + 50);
    }
}
