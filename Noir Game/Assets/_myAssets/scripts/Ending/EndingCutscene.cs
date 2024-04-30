using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class EndingCutscene : MonoBehaviour
{
    private void OnTriggerEnter(UnityEngine.Collider other)
    { 
        if (other.gameObject.tag == "Player") 
        {
            SceneManager.LoadScene(2);
        }
    }
}
   

