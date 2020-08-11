using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Wall_Controller : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public GameObject Wall;
    public MeshRenderer Wall_Mesh;
    public Material Wall1;
    public Material Wall2;
    public GameObject wallTextObject;
    public TextMeshPro wallText;

    bool wallState = false;

    [SerializeField] private UnityEvent OnClick = new UnityEvent();

    // Update is called once per frame
    void Update()
    {
        if (wallState == false)
        {
            wallText.text = "Change Wall To Second Style";
        }
        else
        {
            wallText.text = "Change Wall To First Style";
        }

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        wallTextObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        wallTextObject.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (wallState == false)
        {
            Material[] mats = Wall_Mesh.materials;
            mats[0] = Wall2;
            Wall_Mesh.materials = mats;
            wallState = true;
        }
        else
        {
            Material[] mats = Wall_Mesh.materials;
            mats[0] = Wall1;
            Wall_Mesh.materials = mats;
            wallState = false;
        }
    }

}


