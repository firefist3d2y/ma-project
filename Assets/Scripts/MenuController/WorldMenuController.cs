using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class WorldMenuController : MonoBehaviour
{
    private UIDocument mainUi;

    private Button world1Btn;
    private Button world2Btn;
    private Button world3Btn;

    private Button backBtn;

    private void OnEnable()
    {
        mainUi = GetComponent<UIDocument>();

        world1Btn = mainUi.rootVisualElement.Q<Button>("world1Btn");
        world1Btn.RegisterCallback<ClickEvent>(world1Click);

        world2Btn = mainUi.rootVisualElement.Q<Button>("world2Btn");
        world2Btn.RegisterCallback<ClickEvent>(world2Click);

        //world3Btn = mainUi.rootVisualElement.Q<Button>("world3Btn");
        //world3Btn.RegisterCallback<ClickEvent>(world3Click);

        backBtn = mainUi.rootVisualElement.Q<Button>("backBtn");
        backBtn.RegisterCallback<ClickEvent>(backClick);

    }

    public void world1Click(ClickEvent e)
    {
        SceneManager.LoadScene("World1");
    }

    public void world2Click(ClickEvent e)
    {
        SceneManager.LoadScene("World2");
    }

    public void world3Click(ClickEvent e)
    {
        SceneManager.LoadScene("World3");
    }

    public void backClick(ClickEvent e)
    {
        SceneManager.LoadScene("MainMenu");
    }
}
