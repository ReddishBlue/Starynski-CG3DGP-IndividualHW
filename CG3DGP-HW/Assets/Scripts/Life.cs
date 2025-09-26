using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField] public float amount = 50;

    void Update()
    {
        if (amount <= 0)
        {
            Destroy(gameObject);
        }
    }
}
