using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int indexI, indexJ; //Vari�veis de localiza��o para os blocos da matriz.

    [SerializeField] Sprite spriteX, spriteCirculo;

    [SerializeField] Sprite spriteVazia;

    

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
    public void TrocasSprite()
    {

    }
}
