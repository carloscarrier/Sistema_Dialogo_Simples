using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressE : MonoBehaviour
{
    public int count = 0;

    [Header("Controle de ligar/desligar UI:")]
    [Space]
    public GameObject Dialogue_UI;
    [Space]
    [Header("Chama o inicio das falas do personagem:")]
    [Space]
    public Dialogue dialogue;
    public Dialogue dialogueDois;


    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("ENTROU NO GET KEY E");


            if (count == 0)
            {
                Dialogue_UI.SetActive(true);
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            }

            if (count == 1)
            {
                Dialogue_UI.SetActive(true);
                FindObjectOfType<DialogueManager>().StartDialogue(dialogueDois);
            }
        }
    }
}
