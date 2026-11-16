using UnityEngine;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour
{
    public GameObject winUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Time.timeScale = 0;
            winUI.SetActive(true); 
        }
    }

    public void LoadLevel(int levelIndex)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(levelIndex);
    }

    public void LoadNextLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
