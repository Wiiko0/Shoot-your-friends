using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private Animator _animator;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 180;
        QualitySettings.vSyncCount = 0; // Disable VSync
    }

    // Update is called once per frame
    void Update()
    {
        var keyboard = Keyboard.current;
        if (keyboard.wKey.isPressed)
        {
            transform.position += Vector3.up * Time.deltaTime * _speed;
            _animator.SetBool("isWalking", true);

        }
        if(keyboard.sKey.isPressed)
        {
            transform.position += Vector3.down * Time.deltaTime * _speed;
            _animator.SetBool("isWalking", true);
        }
        if (keyboard.aKey.isPressed)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            transform.position += Vector3.left * Time.deltaTime * _speed;
            _animator.SetBool("isWalking", true);
        }
        if (keyboard.dKey.isPressed)
        {
            transform.eulerAngles = new Vector3(0, 180, 0); 
            transform.position += Vector3.right * Time.deltaTime * _speed;
            _animator.SetBool("isWalking", true);
        }
        if(!keyboard.wKey.isPressed && !keyboard.sKey.isPressed && !keyboard.aKey.isPressed && !keyboard.dKey.isPressed)
        {
            _animator.SetBool("isWalking", false);
        }
        
    }
    //Mouse.current.leftButton.wasPressedThisFrame
    //Instantiate();
}
