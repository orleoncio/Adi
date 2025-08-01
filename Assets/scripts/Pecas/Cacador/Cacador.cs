using System;
using UnityEngine;

public class Cacador : Pecas
{
    public GameObject prefab;
    public GameObject instanciaNaCena;
    public Cacador(int casa, GameObject prefab) : base(casa)
    {
        this.prefab = prefab;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Instancia(Vector3 posicao)
    {
        instanciaNaCena = GameObject.Instantiate(prefab, posicao, Quaternion.Euler(0, 270, 0));
        CacadorMonoBehaviour cacadorMonoBehaviour = instanciaNaCena.AddComponent<CacadorMonoBehaviour>();
    }
}
