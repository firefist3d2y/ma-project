using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using System.Data;
using System;


public class ScoreMenuController : MonoBehaviour
{
    private UIDocument mainUi;

    private ListView listView;

    private Button backBtn;

    private void OnEnable()
    {
        mainUi = GetComponent<UIDocument>();

        listView = mainUi.rootVisualElement.Q<ListView>("ListView");

        SortedDictionary<int, SortedDictionary<int, List<string>>>
        scores = DataPersistenceManager.getInstance().GetGameData().getScores();

        foreach (KeyValuePair<int,SortedDictionary<int, List<string>>> world in scores)
        {
            foreach(KeyValuePair<int,List<string>> score in world.Value)
            {
                listView.hierarchy.Add(new Label("World " + (world.Key) + " Level " + (score.Key) + " Score " + score.Value[0] + " Time " + score.Value[1]));
            }
        }
        backBtn = mainUi.rootVisualElement.Q<Button>("backBtn");
        backBtn.RegisterCallback<ClickEvent>(backClick);

    }


    public void backClick(ClickEvent e)
    {
        SceneManager.LoadScene("MainMenu");
    }
}
