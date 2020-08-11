using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Rug_Controller : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public GameObject Rug;
    public MeshRenderer Rug_Mesh;
    public Material Fabric1;
    public Material Fabric2;
    public GameObject rugTextObject;
    public TextMeshPro rugText;

    bool rugState = false;

    [SerializeField] private UnityEvent OnClick = new UnityEvent();

    // Update is called once per frame
    void Update()
    {
        if (rugState == false)
        {
            rugText.text = "Change Rug To Second Fabric";
        }
        else
        {
            rugText.text = "Change Rug To First Fabric";
        }

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        rugTextObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        rugTextObject.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (rugState == false)
        {
            Material[] mats = Rug_Mesh.materials;
            mats[0] = Fabric2;
            Rug_Mesh.materials = mats;
            rugState = true;
        }
        else
        {
            Material[] mats = Rug_Mesh.materials;
            mats[0] = Fabric1;
            Rug_Mesh.materials = mats;
            rugState = false;
        }
    }

}


