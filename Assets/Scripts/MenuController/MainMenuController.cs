using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private UIDocument mainUi;

    private Button playBtn;
    private Button settingsBtn;
    private Button scoreBtn;

    private void OnEnable()
    {
        mainUi = GetComponent<UIDocument>();

        playBtn = mainUi.rootVisualElement.Q<Button>("playBtn");
        playBtn.RegisterCallback<ClickEvent>(playClick);

        settingsBtn = mainUi.rootVisualElement.Q<Button>("settingsBtn");
        settingsBtn.RegisterCallback<ClickEvent>(settingsClick);

        scoreBtn = mainUi.rootVisualElement.Q<Button>("scoreBtn");
        scoreBtn.RegisterCallback<ClickEvent>(scoreClick);

    }

    public void playClick(ClickEvent e)
    {
        SceneManager.LoadScene("World1");
    }

    public void settingsClick(ClickEvent e)
    {
        SceneManager.LoadScene("Option");
    }

    public void scoreClick(ClickEvent e)
    {
    }

}
