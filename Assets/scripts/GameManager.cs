using UnityEngine;
using UnityEngine.SceneManagement;//needs to be used when changing scenes, working with scenes
public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float GameDelayTime = 1f;
    public playerscript movement;
    public GameObject completeLevelUI;

    public void LevelWon()
    {
        movement.enabled = false;
        completeLevelUI.SetActive(true);//'false' to disable
    }
    public void GameEnd() {
        //allows the function to be seen from elsewhere
        if (gameHasEnded == false)//prevents the game ending multiple times
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            movement.enabled = false;
            Invoke("Restart",GameDelayTime);//invoke function waits before invoking the function
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//returns name of active scene; can also give parameter "Level 1"
    }
}
