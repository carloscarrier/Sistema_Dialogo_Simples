using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject PressE;
    public GameObject DialogueUI;


    private void OnTriggerEnter(Collider other)
    {
        if ((other.CompareTag("Player")))
        {
            Debug.Log(other);

            PressE.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PressE.SetActive(false);
            DialogueUI.SetActive(false);
        }
    }
}
