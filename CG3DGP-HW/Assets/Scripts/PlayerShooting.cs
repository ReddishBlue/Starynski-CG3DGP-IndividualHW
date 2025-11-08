using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    [SerializeField] private GameObject shootPoint;
    [SerializeField] private ParticleSystem muzzleEffect;
    [SerializeField] private AudioSource shootSound;
    public int manaAmount;
    public float fireRate;
    Animator animator;

    private void Awake() {
        animator = GetComponentInChildren<Animator>();
    }
 

    public void OnFire(InputValue value)
    {
        animator.SetBool("Shooting", value.isPressed);
        
        if (value.isPressed)
        {
            InvokeRepeating("Shoot", fireRate, fireRate);
        }
        else {
            CancelInvoke();
        }
    }

    private void Shoot() {
        if (manaAmount > 0 && Time.timeScale > 0) {
            manaAmount--;

            GameObject clone = Instantiate(bulletPrefab);
            clone.transform.position = shootPoint.transform.position;
            clone.transform.rotation = shootPoint.transform.rotation;

            muzzleEffect.Play();
            shootSound.Play();
        }
    }
}
