using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int indexI, indexJ; //Vari�veis de localiza��o para os blocos da matriz.

    [SerializeField] Sprite spriteX, spriteCirculo;

    [SerializeField] Sprite spriteVazia;

    public bool trocarSprite;

    

    //M�todo para ter o endere�o das �reas.
    public void DefinirEndereco(int i, int j)
    {
        indexI = i;
        indexJ = j;
    }

    //M�todo para ver se o bot�o da �rea foi clicado.
    public void BotaoClicado()
    {

    }

    //M�todo para trocar a sprite da �rea por  um X ou  c�rculo.
    public void ModoTrocarSprite()
    {
        if (trocarSprite)//se trocarSprite for true. Traduzindo: se a vari�vel trocarSprite estiver ligada...
        {
            trocarSprite = false;//fica false. Traduzindo: a vari�vel vai desligar...
        }
        else //sen�o. Traduzindo: se a vari�vel trocarSprite N�O estiver ligada...
        {
            trocarSprite = true;//fica true. Traduzindo: a vari�vel vai ligar.
        }
    }

    //M�todo que altera a sprite entre X e o c�rculo
    public void TrocarSprite()
    {

    }

}
