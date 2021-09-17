using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picker : MonoBehaviour
{
    private Collider2D _collider;

    private void Awake()
    {
        _collider = GetComponent<Collider2D>();
    }

    public Collider2D GetCollider2D()
    {
        return _collider;
    }
}
