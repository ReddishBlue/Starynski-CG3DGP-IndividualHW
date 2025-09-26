using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public List<Enemy> enemies;
    public static EnemyManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            //print("duplicated ScoreManager, ignoring this one");
            Debug.LogError("Duplicated EnemyManager, ignoring this one", gameObject);
        }
    }

}
