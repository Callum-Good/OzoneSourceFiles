using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Couch_Controller : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public GameObject Seat;
    public MeshRenderer Seat_Mesh;
    public Material Leather;
    public Material Fabric;
    public GameObject seatTextObject;
    public TextMeshPro seatText;

    bool seatState = false;

    [SerializeField] private UnityEvent OnClick = new UnityEvent();

    // Update is called once per frame
    void Update()
    {
        if (seatState == false)
        {
            seatText.text = "Change Couch To Fabric";
        }
        else
        {
            seatText.text = "Change Couch To Leather";
        }

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        seatTextObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        seatTextObject.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (seatState == false)
        {
            Material[] mats = Seat_Mesh.materials;
            mats[0] = Fabric;
            Seat_Mesh.materials = mats;
            seatState = true;
        }
        else
        {
            Material[] mats = Seat_Mesh.materials;
            mats[0] = Leather;
            Seat_Mesh.materials = mats;
            seatState = false;
        }
    }

}


