using UnityEngine;

public class SpitFlies : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    [SerializeField] private GameObject _explosionPrefab;


    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * _speed;

        var camera = Camera.main;
        
        var leftTop = camera.ViewportToWorldPoint(new Vector3(0, 1, camera.nearClipPlane));
        var rightBottom = camera.ViewportToWorldPoint(new Vector3(1, 0, camera.nearClipPlane));

        var position = transform.position;
        if (position.x < leftTop.x || position.y > leftTop.y || position.x > rightBottom.x || position.y < rightBottom.y)
        {
            Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
