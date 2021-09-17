using TMPro;
using UnityEngine;

public class Sector : MonoBehaviour
{
    [SerializeField] private TMP_Text _quantityText;
    [SerializeField] private Score _score;
    private int _quantity;

    private void Awake()
    {
        GameObject obj = GameObject.Find(nameof(Score));
        _score = obj.GetComponent<Score>();
    }

    private void Start()
    {
        GenerateQuantity();
    }

    private void GenerateQuantity()
    {
        _quantity = Random.Range(10, 1001) * 100;
        _quantityText.text = _quantity.ToString();
    }

    private void OnTriggerEnter2D()
    {
        _score.AddScore(_quantity);
    }
}
