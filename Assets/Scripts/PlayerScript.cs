using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public int test;
    public InputActionAsset controls;
    public int test2;

    private void Awake()
    {
        //controls.Player.Shoot.performed += context => Shoot();
    }

    void Shoot()
    {
        Debug.Log("Test");
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

}
