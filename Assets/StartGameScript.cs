using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class StartGameScript : MonoBehaviour
{
    [SerializeField] private string sceneName;
    
    public void SwitchScene()
    {
        Debug.Log("Test");
        SceneManager.LoadScene(sceneName);
    }
}
