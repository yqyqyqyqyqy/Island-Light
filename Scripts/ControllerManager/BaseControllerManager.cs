﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public abstract class BaseControllerManager : MonoBehaviour
{
    private VRTK_ControllerEvents controllerEvents;

    public abstract void GripReleased();
    public abstract void GripPressed();
    public abstract void TouchpadReleased();
    public abstract void TouchpadPressed();
    public abstract void TriggerReleased();
    public abstract void TriggerPressed();

    private void Awake()
    {
        controllerEvents = GetComponent<VRTK_ControllerEvents>();
        controllerEvents.GripPressed += ControllerEvents_GripPressed;
        controllerEvents.GripReleased += ControllerEvents_GripReleased;

        controllerEvents.TriggerPressed += ControllerEvents_TriggerPressed;
        controllerEvents.TriggerReleased += ControllerEvents_TriggerReleased;

        controllerEvents.TouchpadPressed += ControllerEvents_TouchpadPressed;
        controllerEvents.TouchpadReleased += ControllerEvents_TouchpadReleased;
    }

    private void ControllerEvents_TouchpadReleased(object sender, ControllerInteractionEventArgs e)
    {
        TouchpadReleased();
    }

    private void ControllerEvents_TouchpadPressed(object sender, ControllerInteractionEventArgs e)
    {
        TouchpadPressed();
    }

    private void ControllerEvents_TriggerReleased(object sender, ControllerInteractionEventArgs e)
    {
        TriggerReleased();
    }

    private void ControllerEvents_TriggerPressed(object sender, ControllerInteractionEventArgs e)
    {
        TriggerPressed();
    }

    private void ControllerEvents_GripReleased(object sender, ControllerInteractionEventArgs e)
    {
        GripReleased();
    }

    private void ControllerEvents_GripPressed(object sender, ControllerInteractionEventArgs e)
    {
        GripPressed();
    }
}
