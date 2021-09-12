using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Rotator : MonoBehaviour
{
    private event UnityAction Spin;

    void OnEnable()
    {
        Spin += OnSpin;
    }

    void Update()
    {
        Spin?.Invoke();
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void OnSpin()
    {
        if(Input.GetMouseButton(0))
            gameObject.transform.Rotate(0, 0, 1.5f);
    }
}
