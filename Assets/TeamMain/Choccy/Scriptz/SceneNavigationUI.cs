using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SceneNavigationUI : MonoBehaviour
{
    [Header(" Scene Navigation UI Configurations ")]
    [SerializeField] private Button nextSceneButton; 
    // Start is called before the first frame update
    void Start()
    {
        nextSceneButton.onClick.AddListener(NextUp); 
    }
public void  NextUp()
    {
        GameManager.GetInstance().LoadNextScene();
        nextSceneButton.onClick.RemoveListener(NextUp); 
    }

public void SpecialNext()
    {
        GameManager.GetInstance().Choccy(); 
    }
}
