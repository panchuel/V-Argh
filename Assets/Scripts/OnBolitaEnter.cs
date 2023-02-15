using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnBolitaEnter : MonoBehaviour
{
    public UnityEvent OnButtonPressed;

    public void InvokeEvent()
    {
        OnButtonPressed.Invoke();
    }
}
