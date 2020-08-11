using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Shelf_Controller : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public GameObject Shelf;
    public MeshRenderer Shelf_Mesh;
    public Material Wood1;
    public Material Wood2;
    public GameObject ShelfTextObject1;
    public GameObject ShelfTextObject2;
    public TextMeshPro ShelfText1;
    public TextMeshPro ShelfText2;

    bool curtainState = false;

    [SerializeField] private UnityEvent OnClick = new UnityEvent();

    // Update is called once per frame
    void Update()
    {
        if (curtainState == false)
        {
            ShelfText1.text = "Change Shelves To Second Wood";
            ShelfText2.text = "Change Shelves To Second Wood";
        }
        else
        {
            ShelfText1.text = "Change Shelves To First Wood";
            ShelfText2.text = "Change Shelves To First Wood";
        }

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        ShelfTextObject1.SetActive(true);
        ShelfTextObject2.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ShelfTextObject1.SetActive(false);
        ShelfTextObject2.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (curtainState == false)
        {
            Material[] mats = Shelf_Mesh.materials;
            mats[1] = Wood2;
            Shelf_Mesh.materials = mats;
            curtainState = true;
        }
        else
        {
            Material[] mats = Shelf_Mesh.materials;
            mats[1] = Wood1;
            Shelf_Mesh.materials = mats;
            curtainState = false;
        }
    }

}


