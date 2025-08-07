using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    [SerializeField] private SpitFlies _bulletPrefab; // Prefab for the bullet
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mouse.current.leftButton.wasPressedThisFrame
        //Instantiate();
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            var spit = Instantiate(_bulletPrefab, this.transform.position, default);
            var worldMouse = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            worldMouse.z = transform.position.z;
            spit.transform.right = (worldMouse - transform.position).normalized;
        }


    }
}
