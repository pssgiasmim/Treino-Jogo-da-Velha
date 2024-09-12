using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int indexI, indexJ; //Variáveis de localização para os blocos da matriz.

    [SerializeField] Sprite spriteX, spriteCirculo;

    [SerializeField] Sprite spriteVazia;

    public bool trocarSprite;

    

    //Método para ter o endereço das áreas.
    public void DefinirEndereco(int i, int j)
    {
        indexI = i;
        indexJ = j;
    }

    //Método para ver se o botão da área foi clicado.
    public void BotaoClicado()
    {

    }

    //Método para trocar a sprite da área por  um X ou  círculo.
    public void ModoTrocarSprite()
    {
        if (trocarSprite)//se trocarSprite for true. Traduzindo: se a variável trocarSprite estiver ligada...
        {
            trocarSprite = false;//fica false. Traduzindo: a variável vai desligar...
        }
        else //senão. Traduzindo: se a variável trocarSprite NÃO estiver ligada...
        {
            trocarSprite = true;//fica true. Traduzindo: a variável vai ligar.
        }
    }

    //Método que altera a sprite entre X e o círculo
    public void TrocarSprite()
    {

    }

}
