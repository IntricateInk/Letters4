using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipController : MonoBehaviour {

    [SerializeField]
    private string tooltipText = "";

    public void OnMouseEnter()
    {
        TooltipBodyController.CurrentTooltip = this.tooltipText;
    }

    public void OnMouseExit()
    {
        TooltipBodyController.CurrentTooltip = "";   
    }
}
