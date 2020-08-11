using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class TV_Controller : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public GameObject TV;
    public MeshRenderer TV_Mesh;
    public Material TV_Off;
    public Material TV_On;
    public GameObject tvTextObject;
    public TextMeshPro tvText;

    bool tvState = false;

    [SerializeField] private UnityEvent OnClick = new UnityEvent();

    // Update is called once per frame
    void Update()
    {
        if (tvState == false)
        {
            tvText.text = "Turn On TV";
        }
        else
        {
            tvText.text = "Turn Off TV";
        }

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tvTextObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tvTextObject.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (tvState == false)
        {
            Material[] mats = TV_Mesh.materials;
            mats[1] = TV_On;
            TV_Mesh.materials = mats;
            tvState = true;
        }
        else
        {
            Material[] mats = TV_Mesh.materials;
            mats[1] = TV_Off;
            TV_Mesh.materials = mats;
            tvState = false;
        }
    }

}


