using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private TMP_Text _quantityText;
    private int _quantity;

    private void Start()
    {
        GenerateQuantity();
    }

    public void GenerateQuantity()
    {
        _quantity = Random.Range(10, 1001) * 100;
        _quantityText.text = _quantity.ToString();
    }

    /*void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(this._quantity);
    }*/
}
