using UnityEngine;
using UnityEngine.SceneManagement; 
/// <summary>
/// cm: scene manager for on click gameflow 
/// </summary>
public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager GetInstance()
    {
        return instance;
    }
    private void Awake()
    {
        if (instance != null && instance != this)
        {Destroy(this); return; }
        instance = this; 
    }
 

    public void Aree()
    {

    }
    public void Lula()
    {

    }
    public void Mary()
    {

    }
    // example of selective scene as control 
    public void Choccy()
    {
        SceneManager.LoadScene(SceneCollection.Digi.ToString()); 
    }

    public void Digi()
    {

    }

    public void LoadNextScene()
    {
        // accounts for running scene, grabs index # +1 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }
    public void LoadScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString()); 
    }
}
/// <summary>
///  cm : fyi enum names must be in same order as build settings 
/// </summary>
public enum SceneCollection
{
    Mary, //0 
    Lula, // 1
    Aree, // 2 
    Choccy, //3 
    Digi, //4 
}
