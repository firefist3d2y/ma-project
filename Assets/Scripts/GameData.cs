using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData 
{
    //scores saved bay world and level
    private SortedDictionary<int, SortedDictionary<int, int>> 
        scores = new SortedDictionary<int, SortedDictionary<int, int>>();

    public void saveLevel(int world, int level, int score)
    {
        if (!scores.ContainsKey(world))
        {
            scores.Add(world, new SortedDictionary<int, int>());
        }

        if (!scores[world].ContainsKey(level)) 
        {
            scores[world].Add(world, score);
        }
        else
        {
            scores[world][level] = score;
        }
    }

    public int getWorld()
    {
        return scores.Count;
    }

    public int getLevel(int world)
    {
        return scores[world - 1].Count;
    }

    public int getScore(int world, int level)
    {
        return scores[world - 1][level - 1];
    }

    public SortedDictionary<int, SortedDictionary<int, int>> getScores() 
    {
        return scores;
    }
}
