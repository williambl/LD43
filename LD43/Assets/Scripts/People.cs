public class People {

    public float happiness;
    public int amountOfPeople;

    float happinessPerSecond;

    public People() {
        happiness = 0.5f;
        amountOfPeople = 500;
        happinessPerSecond = -0.01f;
    }

    public void Update() {
        happiness += happinessPerSecond;
    }
}
