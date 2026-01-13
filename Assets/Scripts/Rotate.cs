using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;
 
    void Update()
    {
        Rotating();
    }

    private void Rotating()
    {
        transform.rotation *= Quaternion.Euler(0, _rotateSpeed * Time.deltaTime, 0);
    }
}
