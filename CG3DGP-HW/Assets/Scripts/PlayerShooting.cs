using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    [SerializeField] private GameObject shootPoint;


    public void OnFire(InputValue value)
    {
        if (value.isPressed)
        {
            GameObject clone = Instantiate(bulletPrefab);

            clone.transform.position = shootPoint.transform.position;
            clone.transform.rotation = shootPoint.transform.rotation;
        }
    }

    void Update()
    {
        // =========== New Input System ============\\

        // =========== Old Input System ============\\
        // if (Input.GetKeyDown(KeyCode.Mouse0)) //Mouse0 = left click, Mouse1 = right click, Mouse2 = middle click
        // {
        //     Instantiate(bulletPrefab, shootPoint.transform.position, shootPoint.transform.rotation);
        // }
    }
}
