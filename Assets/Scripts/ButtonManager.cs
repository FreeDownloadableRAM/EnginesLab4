using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{

    //get audio component
    AudioSource audioData; //plays the clip in the component


    //Button Play Script
    public void OnButtonPress()
    {
        //Get sound stuff
        audioData = GetComponent<AudioSource>();

        //SceneManager.LoadScene(sceneName: "SampleScene");

        //Play the Sound
        audioData.Play(0);

    }


}
