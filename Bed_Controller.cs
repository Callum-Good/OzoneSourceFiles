using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Bed_Controller : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public GameObject Bed;
    public MeshRenderer Bed_Mesh;
    public Material Frame1;
    public Material Quilt1;
    public Material Blanket1;
    public Material Frame2;
    public Material Quilt2;
    public Material Blanket2;
    public GameObject bedTextObject;
    public TextMeshPro bedText;

    bool bedState = false;

    [SerializeField] private UnityEvent OnClick = new UnityEvent();

    // Update is called once per frame
    void Update()
    {
        if (bedState == false)
        {
            bedText.text = "Change Bed To Second Style";
        }
        else
        {
            bedText.text = "Change Bed To First Style";
        }

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        bedTextObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        bedTextObject.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (bedState == false)
        {
            Material[] mats = Bed_Mesh.materials;
            mats[4] = Frame2;
            mats[0] = Quilt2;
            mats[1] = Blanket2;
            Bed_Mesh.materials = mats;
            bedState = true;
        }
        else
        {
            Material[] mats = Bed_Mesh.materials;
            mats[4] = Frame1;
            mats[0] = Quilt1;
            mats[1] = Blanket1;
            Bed_Mesh.materials = mats;
            bedState = false;
        }
    }

}


