using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public string startScene;
    public void LoadLevel() 
    { 
        SceneManager.LoadScene(startScene);
    }
    public void QuitGame() 
    { 
        Application.Quit(); 
    }
   
}
