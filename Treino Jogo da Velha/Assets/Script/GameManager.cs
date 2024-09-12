using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int indexI, indexJ; //Variáveis de localização para os blocos da matriz.

    [SerializeField] Sprite spriteX, spriteCirculo;

    [SerializeField] Sprite spriteVazia;

    

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
    public void TrocasSprite()
    {

    }
}
