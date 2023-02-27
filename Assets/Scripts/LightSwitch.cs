using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LightSwitch : MonoBehaviour
{
    // 
    public delegate void SwitchLight();
    public event SwitchLight TriggerLight;

    //public float Health 
    //{ 
    //    get => Health; 
    //    set { Health = value;
    //        healthChanged?.Invoke();
    //    } 
    //}
    
    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Space)) return;

        TriggerLight?.Invoke();
    }
}
