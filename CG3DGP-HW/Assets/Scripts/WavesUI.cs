using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WavesUI : MonoBehaviour
{
    TMP_Text text;

    void Awake() {
        text = GetComponent<TMP_Text>();
    }
    void Start() {
        WavesManager.instance.onChanged.AddListener(RefreshText);
    }

    void RefreshText() {
        text.text = "Remaining Waves: " + WavesManager.instance.waves.Count;
    }
}
