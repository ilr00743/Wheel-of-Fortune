using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private TMP_Text _quantityText;
    [SerializeField] private Wheel _wheel;
    private Score _score;
    private Collider2D _collider;
    private int _quantity;

    public int GetQuantity() => _quantity;

    private void Start()
    {
        GameObject obj = GameObject.Find(nameof(Score));
        _score = obj.GetComponent<Score>();

        GenerateQuantity();
    }

    public void GenerateQuantity()
    {
        _quantity = Random.Range(10, 1001) * 100;
        _quantityText.text = _quantity.ToString();
    }

    private void OnTriggerEnter2D()
    {
        Debug.Log(_quantity);
        _score.AddScore(_quantity);
    }
}
