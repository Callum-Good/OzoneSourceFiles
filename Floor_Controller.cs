using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Floor_Controller : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public GameObject Floor;
    public MeshRenderer Floor_Mesh;
    public Material Wood;
    public Material Stone;
    public GameObject floorTextObject;
    public TextMeshPro floorText;

    bool floorState = false;

    [SerializeField] private UnityEvent OnClick = new UnityEvent();

    // Update is called once per frame
    void Update()
    {
        if (floorState == false)
        {
            floorText.text = "Change Floor To Stone";
        }
        else
        {
            floorText.text = "Change Floor To Wood";
        }

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        floorTextObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        floorTextObject.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (floorState == false)
        {
            Material[] mats = Floor_Mesh.materials;
            mats[0] = Stone;
            Floor_Mesh.materials = mats;
            floorState = true;
        }
        else
        {
            Material[] mats = Floor_Mesh.materials;
            mats[0] = Wood;
            Floor_Mesh.materials = mats;
            floorState = false;
        }
    }

}


