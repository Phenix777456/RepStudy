using UnityEngine;

public class Size : MonoBehaviour
{
    [SerializeField] private float _changeSize;
    
    void Update()
    {
        ChengingSize();
    }

    private void ChengingSize()
    {
        float siseForVector = _changeSize * Time.deltaTime;
        transform.localScale += new Vector3(siseForVector, siseForVector, siseForVector);
    }
}
