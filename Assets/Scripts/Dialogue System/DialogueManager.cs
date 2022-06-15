using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    public bool pegouQuest;  //Caso o jogador tenha alguma quest vinculada ao dialogo, pode ser usado como verificação, é chamada na função EndDialogue();

    private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {

        if (sentences.Count == 0)
        {
            EndDialogue();

            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;

    }

    void EndDialogue()
    {
        PressE pressECount = FindObjectOfType<PressE>();

        if (pressECount.count == 0)
        {
            pressECount.count++;   //O count da a indicação de qual dialogo será o próximo
            if (pegouQuest == false)
            {
                pegouQuest = true;
            }
        }

        if (pressECount.count == 1)
        {
            return;
        }
        Debug.Log("End of conversation.");
    }
}
