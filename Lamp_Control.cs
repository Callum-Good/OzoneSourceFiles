using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Lamp_Control : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public GameObject lamp;
    public Light lampLight;
    public GameObject lampTextObject;
    public TextMeshPro lampText;

    [SerializeField] private UnityEvent OnClick = new UnityEvent();

    // Update is called once per frame
    void Update()
    {
        if (lampLight.enabled == false)
        {
            lampText.text = "Turn On Lamp";
        }
        else
        {
            lampText.text = "Turn Off Lamp";
        }

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        lampTextObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        lampTextObject.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (lampLight.enabled == false)
        {
            lampLight.enabled = true;
        }
        else
        {
            lampLight.enabled = false;
        }
    }

}
