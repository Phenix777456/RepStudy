using UnityEngine;

public class Ìovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    void Update()
    {
        Move();
    }
    
    private void Move()
    {
        transform.Translate(0, 0, -_moveSpeed * Time.deltaTime);
    }
}
