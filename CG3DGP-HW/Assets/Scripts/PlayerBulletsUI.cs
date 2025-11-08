using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerBulletsUI : MonoBehaviour
{
    private TMP_Text text;
    [SerializeField] PlayerShooting targetShooting;

    void Awake() {
        text = GetComponent<TMP_Text>();
    }

    void Update() {
        text.text = "Mana: " + targetShooting.manaAmount;
    }
}
