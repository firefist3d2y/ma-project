using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Profiling;

public class DataPersistenceManager
{
    private GameData gameData;
    public string savePath = "/saveRollGame.json";

    private static DataPersistenceManager Instance;

    public static DataPersistenceManager getInstance()
    {
        if (Instance == null)
        {
            Instance = new DataPersistenceManager();
            Instance.LoadData();
        }
        
        return Instance;
    }

    public GameData GetGameData()
    {
        return gameData;
    }

    public void SaveLevel(int world, int level, string score, string time)
    {
        gameData.saveLevel(world, level, score, time);
        SaveData();
    }

    private void SaveData()
    {
        try
        {
            // create the directory the file will be written to if it doesn't already exist
            Directory.CreateDirectory(Path.GetDirectoryName(savePath));

            // serialize the C# game data object into Json
            string dataToStore = JsonUtility.ToJson(gameData, true);

            // write the serialized data to the file
            using FileStream stream = new FileStream(savePath, FileMode.Create);
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.Write(dataToStore);
            }

        }
        catch (Exception e)
        {
            Debug.LogError("Error occured when trying to save data to file: " + savePath + "\n" + e);
        }
    }

    private void LoadData()
    {
        if (File.Exists(savePath))
        {
            try
            {
                // load the serialized data from the file
                string dataToLoad = "";
                using (FileStream stream = new FileStream(savePath, FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        dataToLoad = reader.ReadToEnd();
                    }
                }
                // deserialize the data from Json back into the C# object
                gameData = JsonUtility.FromJson<GameData>(dataToLoad);
            }
            catch (Exception e)
            {
                Debug.LogError("Error occured when trying to load file at path: "
                    + savePath + " and backup did not work.\n" + e);
                gameData = new GameData();
            }
        }
        else
        {
            gameData = new GameData();
        }
    }
}

