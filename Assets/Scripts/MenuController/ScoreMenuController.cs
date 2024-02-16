using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class ScoreMenuController : MonoBehaviour
{
    private UIDocument mainUi;

    private ListView listView;

    private Button backBtn;

    private void OnEnable()
    {
        mainUi = GetComponent<UIDocument>();

        listView = mainUi.rootVisualElement.Q<ListView>("ListView");

        SortedDictionary<int, SortedDictionary<int, int>>
        scores = DataPersistenceManager.getInstance().GetGameData().getScores();

        foreach (KeyValuePair<int,SortedDictionary<int, int>> world in scores)
        {
            foreach(KeyValuePair<int,int> score in world.Value)
            {
                listView.hierarchy.Add(new Label("World " + (world.Key + 1) + " Level " + (score.Key + 1) + " Score " + score.Value));
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
