using UnityEngine;

public class People {

    public float happiness;
    public int amountOfPeople;

    float happinessPerSecond;
    int secondsPerPeople;

    public People() {
        happiness = 0.5f;
        amountOfPeople = 500;
        happinessPerSecond = -0.01f;
        secondsPerPeople = 5;
    }

    public void Update() {
        happiness += happinessPerSecond;

        if (((int)Time.time % secondsPerPeople) == 0)
            amountOfPeople++;

        Debug.Log("Happiness: " + happiness);
        Debug.Log("People: " + amountOfPeople);
    }
}
