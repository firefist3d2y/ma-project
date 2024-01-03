using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PauseMenuController : MonoBehaviour
{
    private UIDocument pauseUi;

    private Button resumeBtn;
    private Button settingsBtn;
    private Button menuBtn;

    public GameObject pauseObj;

    private bool gameIsPaused = false;

    private void OnEnable()
    {
        pauseUi = GetComponent<UIDocument>();

        resumeBtn = pauseUi.rootVisualElement.Q<Button>("resumeBtn");
        resumeBtn.RegisterCallback<ClickEvent>(resumeClick);

        settingsBtn = pauseUi.rootVisualElement.Q<Button>("settingsBtn");
        settingsBtn.RegisterCallback<ClickEvent>(settingsClick);

        menuBtn = pauseUi.rootVisualElement.Q<Button>("menuBtn");
        menuBtn.RegisterCallback<ClickEvent>(menuClick);

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                resumeClick(null);
            }
            else
            {
                pauseClick();
            }

        }
    }

    public void resumeClick(ClickEvent e)
    {
        pauseGame();
        pauseObj.SetActive(true);
        gameObject.SetActive(false);
    }

    public void settingsClick(ClickEvent e)
    {
        
    }

    public void menuClick(ClickEvent e)
    {
        pauseGame();
        SceneManager.LoadScene("MainMenu");
    }

    public void pauseClick()
    {
        pauseGame();
        pauseObj.SetActive(false);
        gameObject.SetActive(true);
    }

    private void pauseGame()
    {
        if (gameIsPaused)
        {
            gameIsPaused = false;
            Time.timeScale = 1f;
        }
        else
        {
            gameIsPaused = true;
            Time.timeScale = 0f;
        }
    }
}
