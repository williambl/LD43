using UnityEngine;

public class Fort {

    public float happiness;
    public int amountOfPeople;

    public float health;

    float happinessPerSecond;
    int secondsPerPeople;

    public Fort() {
        happiness = 0.5f;
        amountOfPeople = 500;
        health = 1.0f;
        happinessPerSecond = -0.01f;
        secondsPerPeople = 5;
    }

    public void Update() {
        happiness += happinessPerSecond;

        if (((int)Time.time % secondsPerPeople) == 0)
            amountOfPeople++;

        Debug.Log("Happiness: " + happiness);
        Debug.Log("People: " + amountOfPeople);
        Debug.Log("Health: " + health);
    }

    public void DoDamage(float damage) {
        if (damage > 20)
            amountOfPeople -= Random.Range(1, 75);
        
        health -= damage/(GameManager.manager.enemies.damageBase + 50);
    }
}
