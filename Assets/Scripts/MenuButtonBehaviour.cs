
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuButtonBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject SettingsPanel;




    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Settings()
    {
     
        SettingsPanel.SetActive(true);
        
    }
    public void SettingsExit()
    {
        SettingsPanel.SetActive(false);
    }
}
