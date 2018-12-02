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
        if (health > 0.7f)
            happiness += 0.005f;
        else if (health < 0.5f)
            happiness -= 0.01f;

        int amountOfFood = GameManager.manager.resources.resourceList.Find(x => x.name == "Food").amount;

        if (amountOfPeople > amountOfFood) {
            happiness -= 0.2f;
            amountOfPeople -= amountOfPeople-amountOfFood;
        } else if (amountOfFood > 2*amountOfPeople) {
            happiness += 0.01f;

            if (((int)Time.time % secondsPerPeople) == 0)
                amountOfPeople = (int)(amountOfPeople * 1.25);
        }
        
        amountOfPeople = Mathf.Max(0, amountOfPeople);
        happiness = Mathf.Clamp(happiness, 0, 1);
        health = Mathf.Clamp(health, 0, 1);

        happinessUI.ChangeLabelAndBackground("Happiness: " + happiness, happiness);
        populationUI.ChangeLabelAndBackground("People: " + amountOfPeople, amountOfPeople/1000);
        healthUI.ChangeLabelAndBackground("Health: " + health, health);
    }

    public void DoDamage(float damage) {
        int peopleLoss = 0;
        if (damage > 20) {
            peopleLoss = Random.Range(1, 75);
            amountOfPeople -= peopleLoss;
        }
        
        float healthLoss = damage/(GameManager.manager.enemies.damageBase + 50);
        health -= healthLoss;

        UIManager.manager.CreateAlert("Attack!", "We've been attacked! The attackers did "+healthLoss+" damage to our fort and killed "+peopleLoss+" people!");
    }
}
