using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] float delayInSeconds = 2f;

   public void LoadStartMenu() {
        SceneManager.LoadScene(0);
   }

   public void LoadGameScene() {
        SceneManager.LoadScene(1);    
   }

   public void LoadGameOverScene() {
        StartCoroutine(WaitAndLoad());
   }

    private IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene(2);
    }

   public void QuitGame() {
        Application.Quit(); 
   }
}
