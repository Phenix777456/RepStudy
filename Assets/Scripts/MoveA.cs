using UnityEngine;

public class MoveA : MonoBehaviour
{
    [SerializeField] private float _changeSize;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _moveSpeed;
    private const string Vertical = nameof(Vertical);

    void Update()
    {
        Move();
    }

    private void Move()
    {
        float siseForVector = _changeSize * Time.deltaTime;

        transform.Translate(Vector3.forward * -_moveSpeed * Time.deltaTime);
        transform.Rotate(_rotateSpeed * Time.deltaTime * Vector3.up);
        transform.localScale += new Vector3(siseForVector, siseForVector, siseForVector);
    }
}
