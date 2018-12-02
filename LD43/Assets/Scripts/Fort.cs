using UnityEngine;
using UnityEngine.UI;

public class Fort {

    public float happiness;
    NumberUIElement happinessUI;

    public int amountOfPeople;
    NumberUIElement populationUI;

    public float health;
    NumberUIElement healthUI;

    int secondsPerPeople;

    public Fort() {
        happiness = 0.5f;
        amountOfPeople = 500;
        health = 1.0f;
        secondsPerPeople = 5;

        happinessUI = UIManager.manager.GetUIText().GetComponent<NumberUIElement>();
        populationUI = UIManager.manager.GetUIText().GetComponent<NumberUIElement>();
        healthUI = UIManager.manager.GetUIText().GetComponent<NumberUIElement>();
    }

    public void Update() {
        if (((int)Time.time % secondsPerPeople) == 0)
            amountOfPeople++;

        if (health > 0.7f)
            happiness += 0.005f;
        else if (health < 0.5f)
            happiness -= 0.01f;

        int amountOfFood = GameManager.manager.resources.resourceList.Find(x => x.name == "Food").amount;

        if (amountOfPeople > amountOfFood)
            happiness -= 0.02f;
        else if (amountOfFood > 2*amountOfPeople)
            happiness += 0.01f;

        happinessUI.ChangeLabel("Happiness: " + happiness);
        populationUI.ChangeLabel("People: " + amountOfPeople);
        healthUI.ChangeLabel("Health: " + health);
    }

    public void DoDamage(float damage) {
        if (damage > 20)
            amountOfPeople -= Random.Range(1, 75);
        
        health -= damage/(GameManager.manager.enemies.damageBase + 50);
    }
}
