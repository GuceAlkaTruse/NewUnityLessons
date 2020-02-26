using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "YourDeath")
        {
            StartCoroutine(ReloadLevel());
        }
    }
    private IEnumerator ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        yield return 0;
    }
}
