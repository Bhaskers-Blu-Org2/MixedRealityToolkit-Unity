﻿using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchHandler : MonoBehaviour, IMixedRealityTouchHandler
{

    #region Event handlers
    public TouchEvent OnTouchStarted = new TouchEvent();
    public TouchEvent OnTouchCompleted = new TouchEvent();
    public TouchEvent OnTouchUpdated = new TouchEvent();
    #endregion


    void IMixedRealityTouchHandler.OnTouchCompleted(HandTrackingInputEventData eventData)
    {
        OnTouchCompleted.Invoke(new TouchEventData(eventData, this));
    }

    void IMixedRealityTouchHandler.OnTouchStarted(HandTrackingInputEventData eventData)
    {
        OnTouchStarted.Invoke(new TouchEventData(eventData, this));
    }

    void IMixedRealityTouchHandler.OnTouchUpdated(HandTrackingInputEventData eventData)
    {
        OnTouchUpdated.Invoke(new TouchEventData(eventData, this));
    }
}
