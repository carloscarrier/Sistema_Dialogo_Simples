using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue //como n�o utiliza m�todos de entrada da unity, deixa de ser monobehaviour;
{
    //Este script cria a �rea onde o jogador controlar� 
    //o nome dos personagens do dialogo e as falas destes personagens;
    //Ele ser� chamado quando o personagem do jogador conter o script "PressE e",
    //executar uma a��o de intera��o com outro pesonagem;
    //Ent�o, o "PressE" passar� este script como par�metro na fun��o que iniciar� o dialogo no script "DialogueManager".
    
    public string name;

    [TextArea(3,10)]
    public string[] sentences;
}
