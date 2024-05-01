using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueRepeat : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public GameObject activator;
    public GameObject panel;

    private int index;

    public ClickableDoors connectedDoor;

    void Start()
    {
        activator.SetActive(true);
        panel.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {

        GetComponent<Collider>().enabled = false;

        panel.SetActive(true);

        textComponent.text = string.Empty;
        StartDialogueRepeat();
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            panel.SetActive(false);

            textComponent.text = string.Empty;
        }
    }

    void Update()
    {
        if (panel.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (textComponent.text == lines[index])
                {
                    NextLine();
                }
                else
                {
                    StopAllCoroutines();
                    textComponent.text = lines[index];
                }
            }
        }
    }

    void StartDialogueRepeat()
    {
        if (connectedDoor != null)
        {
            connectedDoor.SetInteractableDoor();
            connectedDoor = null;
        }

        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            panel.SetActive(false);
            GetComponent<Collider>().enabled = true;
        }
    }
}

