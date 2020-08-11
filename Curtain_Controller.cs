using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Curtain_Controller : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public GameObject Curtain;
    public MeshRenderer Curtain_Mesh;
    public Material Fabric1;
    public Material Fabric2;
    public GameObject curtainTextObject;
    public TextMeshPro curtainText;

    bool curtainState = false;

    [SerializeField] private UnityEvent OnClick = new UnityEvent();

    // Update is called once per frame
    void Update()
    {
        if (curtainState == false)
        {
            curtainText.text = "Change Curtains To Second Fabric";
        }
        else
        {
            curtainText.text = "Change Curtains To First Fabric";
        }

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        curtainTextObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        curtainTextObject.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (curtainState == false)
        {
            Material[] mats = Curtain_Mesh.materials;
            mats[0] = Fabric2;
            Curtain_Mesh.materials = mats;
            curtainState = true;
        }
        else
        {
            Material[] mats = Curtain_Mesh.materials;
            mats[0] = Fabric1;
            Curtain_Mesh.materials = mats;
            curtainState = false;
        }
    }

}


