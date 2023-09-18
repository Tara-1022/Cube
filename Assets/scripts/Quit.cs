using UnityEngine;

public class Quit : MonoBehaviour
{
   public void EndGame()
    {
        Debug.Log("QUIT GAME");
        Application.Quit();
    }
}
