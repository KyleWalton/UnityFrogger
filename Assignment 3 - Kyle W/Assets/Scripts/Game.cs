using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;


public class Game : MonoBehaviour
{

    public AudioSource music;

    // Start is called before the first frame update
    private Save CreateSaveGameObject()
    {
        Save save = new Save();

        save.Sname = Data.Instance.playerName;

        save.Slives = Data.Instance.playerLives;

        save.Sspeed = Data.Instance.carSpeed;

        save.Sscore = Data.Instance.score;

        return save;
    }

    public void SaveGame()
    {
        Save save = CreateSaveGameObject();

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
        bf.Serialize(file, save);
        file.Close();

        Debug.Log("Save Games");
    }

    public void LoadGame()
    {
        if (File.Exists(Application.persistentDataPath + "/gamesave.save"))
        {

            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.save", FileMode.Open);
            Save save = (Save)bf.Deserialize(file);
            file.Close();

            Data.Instance.carSpeed = save.Sspeed;
            Data.Instance.playerName = save.Sname;
            Data.Instance.score = save.Sscore;
            Data.Instance.playerLives = save.Slives;

            Debug.Log("Game Loaded");
        }
        else
        {
            Debug.Log("No game saved!");
        }
    }

    public void SaveAsJSON()
    {
        Save save = CreateSaveGameObject();
        string json = JsonUtility.ToJson(save);

        Debug.Log("Saving as JSON: " + json);
    }

    public void toggleMusic()
    {
        if (music.mute)
        {
            music.mute = false;
        }
        else
        {
            music.mute = true;
        }

    }

}
