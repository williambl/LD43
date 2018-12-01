﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    Gods gods;
    Resources resources;
    People people;
    Enemies enemies;

    void Awake () {
        gods = new Gods();
        resources = new Resources();
        people = new People();
        enemies = new Enemies();
        StartCoroutine(UpdateAllThings);
    }

    IEnumerator UpdateAllThings () {
        while (true) {
            yield return new WaitForSeconds(1.0f);
            resources.Update();
            People.Update();
            Gods.Update();
            Enemies.Update();
        }
    }

}
