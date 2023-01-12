using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public int test;
    public InputAction shoot;
    public int test2;

    private void Awake()
    {
        shoot.performed += context => Shoot();
    }

    void Shoot()
    {
        Debug.Log("Test");
    }

    private void OnEnable()
    {
        shoot.Enable();
    }

    private void OnDisable()
    {
        shoot.Disable();
    }

}
