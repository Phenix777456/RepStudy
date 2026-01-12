using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    void Update()
    {
        Move();
    }
    
    private void Move()
    {
        transform.position += new Vector3(0, 0, -_moveSpeed * Time.deltaTime);
    }
}
