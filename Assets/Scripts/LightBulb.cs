using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBulb : MonoBehaviour
{
    // This is the gameobject passed into the inspector
    [SerializeField] GameObject SwitchGameObject;

    // This is the built in Unity Light component, in this case, we will store a reference to the light
    // attached to this gameobject
    Light Bulb;

    // This is an instance of the LightSwitch script that we have created, in this case it will hold a reference
    // to the LightSwitch script on the Switch game object
    LightSwitch m_LightSwitch;

    private void OnEnable()
    {
        // get the light component from this game object, Bulb will now reference that specific instance
        Bulb = GetComponent<Light>();
    }

    void Start()
    {
        // Get the LightSwitch script/component from the gameobject passed into the inspector
        m_LightSwitch = SwitchGameObject.GetComponent<LightSwitch>();

        // Subscribe the OnSwitchTriggered method to the switchLight event on the LightSwitch script
        m_LightSwitch.TriggerLight += OnSwitchTriggered;
    }

    private void OnDisable()
    {
        // Unsubscribe from the TriggerLight event
        m_LightSwitch.TriggerLight -= OnSwitchTriggered;
    }

    // Method to enable/disable the light component
    void OnSwitchTriggered()
    {
        Bulb.enabled = !Bulb.enabled;
    }
}
