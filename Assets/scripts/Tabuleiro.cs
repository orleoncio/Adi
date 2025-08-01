using System.Collections.Generic;
using UnityEngine;

public class Tabuleiro : MonoBehaviour
{
    private List<Casas> casas = new List<Casas>();
    private List<Pecas> pecas = new List<Pecas>();
    public GameObject prefabOnca;
    public GameObject prefabCacador;
    public GameObject prefabCasa;

    void Start()
    {
        CriarListaDeCasas();
        CriarListaDePesas();
        InstanciaTesteDeCasas();
        InstanciaTesteDePecas();
    }

    void Update()
    {
        
    }

    private void InstanciaTesteDePecas()
    {
        foreach(Pecas p in pecas)
        {
            if(p is Cacador casador)
            {
                casador.Instancia(casas[casador.casa].posicao);
            }

            if(p is Onca onca)
            {
                onca.Instancia(casas[onca.casa].posicao);
            }
        }
    }

    private void InstanciaTesteDeCasas()
    {
        foreach(Casas c in casas)
        {
            //c.Instancia();
        }
    }

    private void CriarListaDePesas()
    {
        pecas.Add(new Onca(12,prefabOnca));

        for (int i = 0; i < 15; i++)
        {
            if(i != 12)
            {
                pecas.Add(new Cacador(i, prefabCacador));
            }
        }
    }

    private void CriarListaDeCasas()
    {
        for(int i = 5; i > -2; i--)
        {
            for(int j = 5; j > 0; j--)
            {
                casas.Add(new Casas((i - j) + 6 * (5 - i), new Vector3(i, 0, j), false, prefabCasa));
            }
        }

        Casas[,] matriz = 
        {
            /*0*/ { casas[1], casas[5], casas[6], null, null, null, null, null },
            /*1*/ { casas[0], casas[2], casas[6], null, null, null, null, null },
            /*2*/ { casas[1], casas[3], casas[6], casas[7], casas[8], null, null, null },
            /*3*/ { casas[2], casas[4], casas[8], null, null, null, null, null },
            /*4*/ { casas[3], casas[8], casas[9], null, null, null, null, null },
            /*5*/ { casas[0], casas[6], casas[10], null, null, null, null, null },
            /*6*/ { casas[0], casas[1], casas[2], casas[5], casas[7], casas[10], casas[11], casas[12] },
            /*7*/ { casas[2], casas[6], casas[8], casas[12], null, null, null, null },
            /*8*/ { casas[2], casas[3], casas[4], casas[7], casas[9], casas[12], casas[13], casas[14] },
            /*9*/ { casas[4], casas[8], casas[14], null, null, null, null, null },
            /*10*/ { casas[5], casas[6], casas[11], casas[15], casas[16], null, null, null },
            /*11*/ { casas[6], casas[10], casas[12], casas[16], null, null, null, null },
            /*12*/ { casas[6], casas[7], casas[8], casas[11], casas[13], casas[16], casas[17], casas[18] },
            /*13*/ { casas[8], casas[12], casas[14], casas[18], null, null, null, null },
            /*14*/ { casas[8], casas[9], casas[13], casas[18], casas[19], null, null, null },
            /*15*/ { casas[10], casas[16], casas[20], null, null, null, null, null },
            /*16*/ { casas[10], casas[11], casas[12], casas[15], casas[17], casas[20], casas[21], casas[22] },
            /*17*/ { casas[12], casas[16], casas[18], casas[22], null, null, null, null },
            /*18*/ { casas[12], casas[13], casas[14], casas[17], casas[19], casas[22], casas[23], casas[24] },
            /*19*/ { casas[14], casas[18], casas[24], null, null, null, null, null },
            /*20*/ { casas[15], casas[16], casas[21], null, null, null, null, null },
            /*21*/ { casas[16], casas[20], casas[22], null, null, null, null, null },
            /*22*/ { casas[16], casas[17], casas[18], casas[21], casas[23], casas[26], casas[27], casas[28] },
            /*23*/ { casas[18], casas[22], casas[24], null, null, null, null, null },
            /*24*/ { casas[18], casas[19], casas[23], null, null, null, null, null },
            /*25*/ { null, null, null, null, null, null, null, null },
            /*26*/ { casas[22], casas[27], casas[30], null, null, null, null, null },
            /*27*/ { casas[22], casas[26], casas[28], casas[32], null, null, null, null },
            /*28*/ { casas[22], casas[27], casas[34], null, null, null, null, null },
            /*29*/ { null, null, null, null, null, null, null, null },
            /*30*/ { casas[26], casas[32], null, null, null, null, null, null },
            /*31*/ { null, null, null, null, null, null, null, null },
            /*32*/ { casas[27], casas[30], casas[34], null, null, null, null, null },
            /*33*/ { null, null, null, null, null, null, null, null },
            /*34*/ { casas[28], casas[32], null, null, null, null, null, null }
        };
    }

    
}
