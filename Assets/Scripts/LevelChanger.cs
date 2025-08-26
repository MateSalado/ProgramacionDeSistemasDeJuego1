using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public int sceneCount = 0;
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(sceneCount);
    }
}
