using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Método Awake do instance
    #region Singleton 
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion

    Area[,] areas = new Area[3,3]; //variável da MATRIZ, esse Area(na cor azul), se refere ao script, e areas(na cor branca) é a variável que é a matriz

    int indexI, indexJ; //Variáveis de localização para os blocos da matriz.

    [SerializeField] Sprite spriteX, spriteCirculo;

    [SerializeField] Sprite spriteVazia;

    public bool trocarSprite; //Variável responsável por trocar as sprites entre X e Círculo.

    int diametroCampo = 3;

    //Método para gerar o campo do jogo da velha, com base em uma MATRIZ.
    public void GerarJogoDaVelha()
    {
        //Aqui, a MATRIZ está sendo criada
        for (int i = 0; i < diametroCampo; i++) //Percorre as linhas [ i ] da matriz
        {
            for (int j = 0; j < diametroCampo; j++)//Percorre as colunas [ j ] da matriz
            {
                areas[i, j] = area; //o elemento [i, j] está recebendo o valor de area
            }
        }
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
