using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelect : MonoBehaviour
{
    public int Level = 0;
    public void levels()
    {
        Level =+ 1;
        SceneManager.LoadScene(Level);
        
    }

    public void exit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

}
