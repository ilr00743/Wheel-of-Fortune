using UnityEngine;
using UnityEngine.EventSystems;

public class SpinButton : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Wheel _wheel;
    public void OnPointerClick(PointerEventData eventData)
    {
        _wheel.RotateWheel(true);
    }
}