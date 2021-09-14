using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private TMP_Text _quantityText;
    private Collider2D _coinCollider2D;
    private int _quantity;

    public Collider2D Collider2D { get; }

    private void Start()
    {
        GenerateQuantity();
    }

    public void GenerateQuantity()
    {
        _quantity = Random.Range(10, 1001) * 100;
        _quantityText.text = _quantity.ToString();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(_quantity);
    }
}
