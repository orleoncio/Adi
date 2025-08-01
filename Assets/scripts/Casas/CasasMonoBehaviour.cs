using UnityEngine;

public class CasasMonoBehaviour : MonoBehaviour
{
    private void OnMouseDown()
    {
        transform.position = new Vector3(transform.position.x,10,transform.position.z);
    }
}

