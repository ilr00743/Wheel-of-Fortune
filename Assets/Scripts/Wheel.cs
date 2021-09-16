using UnityEngine;
using UnityEngine.UI;

public class Wheel : MonoBehaviour
{
    [SerializeField] private Button _spinButton;
    [SerializeField] private BoxCollider2D _picker;
    private bool _canSpin = false;
    private float _speed = 0;
    private bool _isFirstSpin = true;

    private void Start()
    {
        //_picker = GetComponent<Picker>().GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        RotateWheel(_canSpin);
    }

    public void RotateWheel(bool canSpin)
    {
        if(canSpin == true)
        {
            _isFirstSpin = false;
            _picker.enabled = false;
            _speed = Random.Range(800, 2500);
            _spinButton.gameObject.SetActive(false);
        }

        if (_speed <= 0)
        {
            _speed = 0;
            if (_isFirstSpin == false)
            {
                _picker.enabled = true;
            }
            _spinButton.gameObject.SetActive(true);
        }

        transform.Rotate(Vector3.forward * _speed * Time.deltaTime);
        _speed -= 10;
    }
}
