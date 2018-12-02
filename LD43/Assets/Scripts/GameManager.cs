using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Gods gods;
    public Resources resources;
    public Fort fort;
    public Enemies enemies;

    public List<Sprite> fortSprites = new List<Sprite>();
    public Image fortImage;

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

    public void Lose (string reason) {
        StopAllCoroutines();
        UIManager.manager.Lose(reason);
    }

    IEnumerator UpdateAllThings () {
        while (true) {
            yield return new WaitForSeconds(1.0f);
            resources.Update();
            fort.Update();
            gods.Update();
            enemies.Update();

            float health = fort.health;
            if (health < 0.01f)
                fortImage.sprite = fortSprites[0];
            else if (health <= 0.1f)
                fortImage.sprite = fortSprites[1];
            else if (health <= 0.2f)
                fortImage.sprite = fortSprites[2];
            else if (health <= 0.4f)
                fortImage.sprite = fortSprites[3];
            else if (health <= 0.6f)
                fortImage.sprite = fortSprites[4];
            else if (health <= 0.8f)
                fortImage.sprite = fortSprites[5];
            else if (health <= 1.0f)
                fortImage.sprite = fortSprites[6];
        }
    }

}
