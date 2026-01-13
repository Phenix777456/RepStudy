using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;
 
    void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.rotation *= Quaternion.Euler(0, _rotateSpeed * Time.deltaTime, 0);
    }
}
