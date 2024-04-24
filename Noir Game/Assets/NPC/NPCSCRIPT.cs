using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCSystem : MonoBehaviour
{
    public GameObject d_template;
    public GameObject canva;
    bool player_detection=false;


    
    
    void OnTriggerStay(Collider other)
    { //this is looking for another object with the tag "player"
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.F))
        {
            canva.SetActive(true);
            //PlayerMovement.dialouge = true;
            NewDialouge("Hi");
            NewDialouge("ITS WORKING LEZ GOOOOO");
            NewDialouge("RAAAHHHHH");
            //canva.transform.GetChild(1).gameObject.SetActive(true);
            player_detection = true;
        }
    }

    void NewDialouge(string text)
    {
        GameObject template_clone = Instantiate(d_template, d_template.transform);
        template_clone.transform.parent = canva.transform;
        template_clone.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = text;
    }
   
   
    private void OnTriggerExit(Collider other)
    {
        
            if (other.gameObject.tag == "Player")
        {
            player_detection = false;
        }
                
    }
}
