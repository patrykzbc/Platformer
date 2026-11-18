using UnityEngine;
using UnityEngine.SceneManagement;

public class loadlevel1 : MonoBehaviour
 
{
    public void loadlevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
}
