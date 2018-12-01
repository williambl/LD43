public class People {

    public float happiness;
    public int amountOfPeople;

    float happinessPerSecond;

    public People() {
        happiness = 0.5;
        amountOfPeople = 500;
        happinessPerSecond = -0.01;
    }

    public void Update() {
        happiness += happinessPerSecond;
    }
}
