using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Gods gods;
    public Resources resources;
    public Fort fort;
    public Enemies enemies;

    public ParticleSystem smokeSystem;
    public ParticleSystem fireSystem;

    public AudioSource audioSrc;
    public AudioClip goodEvent;
    public AudioClip badEvent;
    public AudioClip loss;

    public static GameManager manager;

    void Awake () {
        manager = this;
    }

    void Start () {
        gods = new Gods();
        resources = new Resources();
        fort = new Fort();
        enemies = new Enemies();
        
        smokeSystem.Stop();
        fireSystem.Stop();

        StartCoroutine(UpdateAllThings());
    }

    public void Lose (string reason) {
        StopAllCoroutines();
        UIManager.manager.Lose(reason);
        PlaySound(2);
    }

    IEnumerator UpdateAllThings () {
        while (true) {
            resources.Update();
            fort.Update();
            gods.Update();
            enemies.Update();

            if (fort.health < 0.6)
                smokeSystem.Play();
            else
                smokeSystem.Stop();

            if (fort.health < 0.4)
                fireSystem.Play();
            else
                fireSystem.Stop();
            float health = fort.health;

            yield return new WaitForSeconds(2.0f);
        }
    }

    public void PlaySound (int soundType) {
        switch (soundType) {
            case 0:
                audioSrc.clip = goodEvent;
                audioSrc.Play();
                break;
            case 1:
                audioSrc.clip = badEvent;
                audioSrc.Play();
                break;
            case 2:
                audioSrc.clip = loss;
                audioSrc.Play();
                break;
            default:
                break;
        }
    }

}
