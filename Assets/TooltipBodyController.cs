using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TooltipBodyController : MonoBehaviour {

    private static string _CurrentTooltip = "";
    public static string CurrentTooltip
    {
        get { return TooltipBodyController._CurrentTooltip; }
        set
        {
            TooltipBodyController._CurrentTooltip = value;
            if (OnCurrentTooltipChange != null) OnCurrentTooltipChange();
        }
    }

    private static event Action OnCurrentTooltipChange;

    [SerializeField]
    private GameObject body;

    [SerializeField]
    private Text labelText;


	// Use this for initialization
	void Start () {
        OnCurrentTooltipChange += this.redraw;

        this.redraw();
	}
	
    private void redraw()
    {
        if (CurrentTooltip == "")
        {
            this.body.SetActive(false);
            return;
        }

        this.body.SetActive(true);
        this.labelText.text = CurrentTooltip;
    }
}
