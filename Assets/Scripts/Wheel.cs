using UnityEngine;
using UnityEngine.UI;

public class Wheel : MonoBehaviour
{
    [SerializeField] private Button _spinButton;
    private readonly bool _canSpin = false;
    private float _speed;

    private void Update()
    {
        RotateWheel(_canSpin);
    }

    public void RotateWheel(bool canSpin)
    {
        if (canSpin == true)
        {
            _speed = Random.Range(800, 2500);
            canSpin = false;
            _spinButton.gameObject.SetActive(false);
        }


        if (_speed <= 0)
        {
            _speed = 0;
            _spinButton.gameObject.SetActive(true);
        }

        transform.Rotate(Vector3.forward * _speed * Time.deltaTime);
        _speed -= 10;
    }

    public bool CanSpin()
    {
        return _canSpin;
    }
}
