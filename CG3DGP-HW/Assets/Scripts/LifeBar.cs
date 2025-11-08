using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    private Image image;
    [SerializeField] private Life targetLife;

    void Awake() {
        image = GetComponent<Image>();    
    }

    void Update() {
        image.fillAmount = targetLife.amount / 100; //set the fill amount to some percentage of the playher life total
    }

}
