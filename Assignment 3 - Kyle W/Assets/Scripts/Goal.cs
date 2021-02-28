using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D()
    {
        Debug.Log("Winner!");
        Data.Instance.score += 100;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
