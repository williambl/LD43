using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Gods gods;
    public Resources resources;
    public Fort fort;
    public Enemies enemies;

    public static GameManager manager;

    void Awake () {
        manager = this;
    }

    void Start () {
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
