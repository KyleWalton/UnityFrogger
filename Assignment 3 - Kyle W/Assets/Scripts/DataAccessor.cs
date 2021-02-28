using UnityEngine;
using UnityEngine.UI;

public class DataAccessor : MonoBehaviour
{
    //Allows you to access the Data Instance for Game and End scenes.
    public Text playerLives;

    public Text playerName;

    public Text score;



    // Update is called once per frame
    void Update()
    {
        playerName.text = "" + Data.Instance.playerName;
        playerLives.text = "Lives: " + Data.Instance.playerLives;
        score.text = "Score: " + Data.Instance.score;
    }
}
