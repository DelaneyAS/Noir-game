using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDialouge : MonoBehaviour
{
    int index = 2; 
    private void Update()
    {
       if(Input.GetMouseButtonDown(0) && transform.childCount > 1)
        {
            
                transform.GetChild(index).gameObject.SetActive(true);
                index += 1;
                if(transform.childCount == index)
                {
                    index = 2;
                    //PlayerMovement.dialouge = false;
                }
                else
                {
                    gameObject.SetActive(false);
                }
           
        }
    }

}
