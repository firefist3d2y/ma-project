using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsMenuController : MonoBehaviour
{
    [SerializeField]
    private Button qButton;

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (qButton != null)
        {
            if (PlayerPrefs.GetInt("Quality", -1) != -1)
            {
                QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("Quality"));
            }

            int currentQualityLevel = QualitySettings.GetQualityLevel();
            string currentQualityName = QualitySettings.names[currentQualityLevel];

            qButton.GetComponentInChildren<Text>().text = currentQualityName;
        }
    }

    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quality()
    {
        int currentQualityLevel = QualitySettings.GetQualityLevel();
        int maxQualityLevel = 5;
        if (currentQualityLevel < maxQualityLevel)
        {
            QualitySettings.SetQualityLevel(currentQualityLevel + 1);
        }
        else
        {
            QualitySettings.SetQualityLevel(0);
        }

        PlayerPrefs.SetInt("Quality", currentQualityLevel);

        currentQualityLevel = QualitySettings.GetQualityLevel();
        string currentQualityName = QualitySettings.names[currentQualityLevel];
        qButton.GetComponentInChildren<Text>().text = currentQualityName;
    }

    public void ResetData()
    {

    }

}