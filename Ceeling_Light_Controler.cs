using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Ceeling_Light_Controler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public GameObject lightSwitch;
    public GameObject lightSwitchLights;
    public GameObject lightSwitchTextObject;
    public TextMeshPro lightSwitchText;

    [SerializeField] private UnityEvent OnClick = new UnityEvent();

    // Update is called once per frame
    void Update()
    {
        if (!lightSwitchLights.activeSelf)
        {
            lightSwitchText.text = "Turn On Lights";
        }
        else
        {
            lightSwitchText.text = "Turn Off Lights";
        }

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        lightSwitchTextObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        lightSwitchTextObject.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!lightSwitchLights.activeSelf)
        {
            lightSwitchLights.SetActive(true);
        }
        else
        {
            lightSwitchLights.SetActive(false);
        }
    }

}

