using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

[System.Serializable]
public class GameData 
{
    //scores saved bay world and level
    private SortedDictionary<int, SortedDictionary<int, List<string>>>
        scores = new SortedDictionary<int, SortedDictionary<int, List<string>>>();

    public void saveLevel(int world, int level, string score, string time)
    {
        if (!scores.ContainsKey(world))
        {
            scores.Add(world, new SortedDictionary<int, List<string>>());
        }

        if (!scores[world].ContainsKey(level)) 
        {
            scores[world].Add(level, new List<string>());
            scores[world][level].Add(score);
            scores[world][level].Add(time);
        }
        else
        {
            scores[world][level][0] = score;
            scores[world][level][1] = time;
        }
    }

    public SortedDictionary<int, SortedDictionary<int, List<string>>> getScores() 
    {
        return scores;
    }
}
