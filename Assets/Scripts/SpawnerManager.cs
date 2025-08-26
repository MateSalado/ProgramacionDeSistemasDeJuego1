using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    [SerializeField] EnemyFactory enemyFactory;

    void Start()
    {
        Vector3 pos = transform.position;
        Quaternion rot = transform.rotation;

        Instantiate(enemyFactory.CreateEnemy("Knight"), pos, rot);
        Instantiate(enemyFactory.CreateEnemy("Eldrich"), pos, rot);
        Instantiate(enemyFactory.CreateEnemy("Frog"), pos, rot);
    }
}
