  using System;
  using UnityEngine;
  using UnityEngine.SceneManagement;

  public class MainMenu : MonoBehaviour
  {
      public void StartGame(int id)
      {
          SceneManager.LoadScene(id);
      }

      public void ExitGame()
      {
          Application.Quit();
      }

  }
