using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public Text ValueText;


    // Start is called before the first frame update
    private void Start()
    {
        ValueText.text = PersistentManagerScript.Instance.Value.ToString();
    }

    public void GoToFirstScene()
    {
        SceneManager.LoadScene("Start");
        PersistentManagerScript.Instance.Value++;
    }

    public void GoToSecondScene()
    {
        SceneManager.LoadScene("Start");
        PersistentManagerScript.Instance.Value++;
    }

    public void OnButtonPress()
    {
        //Start game
        SceneManager.LoadScene(sceneName: "Start");
        PersistentManagerScript.Instance.Value++;
    }
}
