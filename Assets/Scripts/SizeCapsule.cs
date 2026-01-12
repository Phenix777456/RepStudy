using UnityEngine;

public class SizeCapsule : MonoBehaviour
{
    [SerializeField] private float _changeSize;
    
    void Update()
    {
        SizeChenge();
    }

    private void SizeChenge()
    {
        float siseForVector = _changeSize * Time.deltaTime;
        transform.localScale += new Vector3(siseForVector, siseForVector, siseForVector);
    }
}
