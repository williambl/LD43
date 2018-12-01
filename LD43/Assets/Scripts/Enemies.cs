using UnityEngine;

public class Enemies {

    public float damageBase;
    float cooldownBase;

    float nextTime;

    public Enemies() {
    
    }

    public void Update() {
        if (Time.time < nextTime)
            return;

        nextTime = Time.time + cooldownBase + Random.Range(1, 25);

        float damage = damageBase + Random.Range(1,20);

        GameManager.manager.fort.DoDamage(damage);
    }
}
