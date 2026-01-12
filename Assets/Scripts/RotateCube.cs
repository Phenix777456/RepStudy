using UnityEngine;

public class RotateCube : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;
 
    void Update()
    {
        Rotation();
    }

    private void Rotation()
    {
        transform.rotation *= Quaternion.Euler(0, _rotateSpeed * Time.deltaTime, 0);
    }
}
