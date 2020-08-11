using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Countertop_Controller : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public GameObject Countertop;
    public MeshRenderer Countertop_Mesh;
    public Material Wood;
    public Material Granite;
    public GameObject countertopTextObject;
    public TextMeshPro countertopText;

    bool curtainState = false;

    [SerializeField] private UnityEvent OnClick = new UnityEvent();

    // Update is called once per frame
    void Update()
    {
        if (curtainState == false)
        {
            countertopText.text = "Change Countertop To Granite";
        }
        else
        {
            countertopText.text = "Change Countertop To Wood";
        }

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        countertopTextObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        countertopTextObject.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (curtainState == false)
        {
            Material[] mats = Countertop_Mesh.materials;
            mats[1] = Granite;
            Countertop_Mesh.materials = mats;
            curtainState = true;
        }
        else
        {
            Material[] mats = Countertop_Mesh.materials;
            mats[1] = Wood;
            Countertop_Mesh.materials = mats;
            curtainState = false;
        }
    }

}


