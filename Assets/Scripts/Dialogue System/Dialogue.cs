using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue //como não utiliza métodos de entrada da unity, deixa de ser monobehaviour;
{
    //Este script cria a área onde o jogador controlará 
    //o nome dos personagens do dialogo e as falas destes personagens;
    //Ele será chamado quando o personagem do jogador conter o script "PressE e",
    //executar uma ação de interação com outro pesonagem;
    //Então, o "PressE" passará este script como parâmetro na função que iniciará o dialogo no script "DialogueManager".
    
    public string name;

    [TextArea(3,10)]
    public string[] sentences;
}
