using UnityEngine;

public class Casas
{
    int numeroDaCasa;
    public Vector3 posicao;
    bool ocupada;
    public GameObject prefab;
    public GameObject instanciaNaCena;

    public Casas(int numeroDaCasa, Vector3 posicao, bool ocupada, GameObject prefab)
    {
        this.numeroDaCasa = numeroDaCasa;
        this.posicao = posicao;
        this.ocupada = ocupada;
        this.prefab = prefab;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Instancia()
    {
        instanciaNaCena = GameObject.Instantiate(prefab, posicao, Quaternion.identity);
        CasasMonoBehaviour casasMonoBehaviour = instanciaNaCena.AddComponent<CasasMonoBehaviour>();
    }
}
