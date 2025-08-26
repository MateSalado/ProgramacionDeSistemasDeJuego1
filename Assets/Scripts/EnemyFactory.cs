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

        foreach(var i in enemies)
        {
            idEnemies.Add(i.Name, i);
        }
    }

    public Enemy CreateEnemy(string name)
    {
        if(!idEnemies.TryGetValue(name, out Enemy enemy))
        {
            return null;
        }
        return Instantiate(enemy) as Enemy;
    }
}
