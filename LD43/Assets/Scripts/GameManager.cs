using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    Gods gods;
    Resources resources;
    Fort fort;
    Enemies enemies;

    public static GameManager manager;

    void Awake () {
        manager = this;

        gods = new Gods();
        resources = new Resources();
        fort = new Fort();
        enemies = new Enemies();
        StartCoroutine(UpdateAllThings());
    }

    IEnumerator UpdateAllThings () {
        while (true) {
            yield return new WaitForSeconds(1.0f);
            resources.Update();
            fort.Update();
            gods.Update();
            enemies.Update();
        }
    }

}
