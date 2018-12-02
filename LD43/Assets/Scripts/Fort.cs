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
            happiness += 0.02f;
        else if (health < 0.5f)
            happiness -= 0.02f;

        int amountOfFood = GameManager.manager.resources.resourceList.Find(x => x.name == "Food").amount;

        if (amountOfPeople > amountOfFood) {
            happiness -= 0.2f;
            amountOfPeople -= amountOfPeople-amountOfFood;
            UIManager.manager.CreateAlert("Starvation!", "Many people have starved because we don't have enough food!");
            GameManager.manager.PlaySound(1);
        } else if (amountOfFood > 2*amountOfPeople) {
            happiness += 0.1f;

            if (((int)Time.time % secondsPerPeople) == 0)
                amountOfPeople = (int)(amountOfPeople * 1.25);
        }
        
        amountOfPeople = Mathf.Max(0, amountOfPeople);
        happiness = Mathf.Clamp(happiness, 0, 1);
        health = Mathf.Clamp(health, 0, 1);

        if (amountOfPeople == 0)
            GameManager.manager.Lose("everybody died. Perhaps you should make sure you have enough food and a good enough fort?");
        if (happiness == 0)
            GameManager.manager.Lose("everybody got fed up and left. Perhaps try not doing as many human sacrifices?");
        if (health == 0)
            GameManager.manager.Lose("the fort collapsed. Perhaps you should have sacrificed to the War God?");

        happinessUI.ChangeLabelAndBackground("Happiness\n" + Mathf.Round(happiness*100) + "%", happiness);
        populationUI.ChangeLabelAndBackground("People\n" + amountOfPeople, amountOfPeople/500);
        healthUI.ChangeLabelAndBackground("Fort Durability\n" + Mathf.Round(health) + "%", health);
    }

    public void DoDamage(float damage) {
        int peopleLoss = 0;
        if (damage > 20) {
            peopleLoss = Random.Range(1, 75);
            amountOfPeople -= peopleLoss;
        }
        
        float healthLoss = damage/(GameManager.manager.enemies.damageBase + 50);

        healthLoss /= (GameManager.manager.gods.godList.Find(x => x.name == "War God").happiness)*2;
        if (healthLoss < 0.1f)
            healthLoss = 0.1f;

        health -= healthLoss;

        UIManager.manager.CreateAlert("Attack!", "We've been attacked! The attackers did "+healthLoss+" damage to our fort and killed "+peopleLoss+" people!");
        GameManager.manager.PlaySound(1);
    }
}
