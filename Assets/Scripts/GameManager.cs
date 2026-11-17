using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        
        print("Quit Game");
    }
}
