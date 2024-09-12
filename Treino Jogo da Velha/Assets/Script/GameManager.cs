using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //M�todo Awake do instance
    #region Singleton 
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion

    Area[,] areas = new Area[3,3]; //vari�vel da MATRIZ, esse Area(na cor azul), se refere ao script, e areas(na cor branca) � a vari�vel que � a matriz

    int indexI, indexJ; //Vari�veis de localiza��o para os blocos da matriz.

    [SerializeField] Sprite spriteX, spriteCirculo;

    [SerializeField] Sprite spriteVazia;

    public bool trocarSprite; //Vari�vel respons�vel por trocar as sprites entre X e C�rculo.

    int diametroCampo = 3;

    //M�todo para gerar o campo do jogo da velha, com base em uma MATRIZ.
    public void GerarJogoDaVelha()
    {
        //Aqui, a MATRIZ est� sendo criada
        for (int i = 0; i < diametroCampo; i++) //Percorre as linhas [ i ] da matriz
        {
            for (int j = 0; j < diametroCampo; j++)//Percorre as colunas [ j ] da matriz
            {
                areas[i, j] = area; //o elemento [i, j] est� recebendo o valor de area
            }
        }
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
