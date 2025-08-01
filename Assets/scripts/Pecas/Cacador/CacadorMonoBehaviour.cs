using System;
using UnityEngine;

public class CacadorMonoBehaviour : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        GameController gameController = FindAnyObjectByType<GameController>();
        if(gameController.rodada % 2 == 1)
        {
            SelectPeca();
            gameController.rodada++;
        }
    }

    public void SelectPeca()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
    }
}
