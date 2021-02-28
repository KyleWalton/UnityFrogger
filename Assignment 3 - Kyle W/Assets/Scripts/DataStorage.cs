using UnityEngine;
using UnityEngine.UI;

public class DataStorage : MonoBehaviour
{
    //MainMenu Storage

    public InputField playerName;

    public Dropdown playerLives;

    public Slider carSpeed;

    public void Update()
    {
        Data.Instance.carSpeed = carSpeed.value;
        Data.Instance.playerName = playerName.text;
        switch (playerLives.value)
        {
            default:
                Data.Instance.playerLives = 3;
                break;
            case 1:
                Data.Instance.playerLives = 3;
                break;
            case 2:
                Data.Instance.playerLives = 2;
                break;
            case 3:
                Data.Instance.playerLives = 1;
                break;
        }
    }
}