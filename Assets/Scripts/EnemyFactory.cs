using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    [SerializeField] private Enemy[] enemies;
    private Dictionary<string, Enemy> idEnemies;
    private void Awake()
    {
        idEnemies = new Dictionary<string, Enemy>();

        foreach(var enemy in enemies)
        {
            idEnemies.Add(enemy.Id, enemy);
        }
    }
}
