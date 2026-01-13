using UnityEngine;

public class Ìovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    void Update()
    {
        Moveing();
    }
    
    private void Moveing()
    {
        transform.Translate(0, 0, -_moveSpeed * Time.deltaTime);
    }
}
