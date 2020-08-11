using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Valve.VR;

public class VRInput : BaseInput
{
    public Camera eventCamera = null;

    public SteamVR_Action_Boolean buttonPress;

    public SteamVR_Input_Sources handType;


    protected override void Awake()
    {
        GetComponent<BaseInputModule>().inputOverride = this;
    }

    public override bool GetMouseButton(int button)
    {
        return buttonPress.state;
    }

    public override bool GetMouseButtonDown(int button)
    {
        return buttonPress.stateDown;
    }

    public override bool GetMouseButtonUp(int button)
    {
        return buttonPress.stateUp;
    }

    public override Vector2 mousePosition
    {
        get
        {
            return new Vector2(eventCamera.pixelWidth / 2, eventCamera.pixelHeight / 2); 
        }
    }


}
