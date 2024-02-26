using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    #region Variables
    public static LevelManager Instance;

    public delegate void OnSphereItemPickedUp();
    private OnSphereItemPickedUp onSphereItemPickedUp;

    public delegate void OnSphereItemDrop();
    private OnSphereItemDrop onSphereItemDrop;

    public delegate void OnEventsReset();
    public OnEventsReset onEventsReset;
    #endregion

    #region Common logic
    // Awake is called before start.
    private void Awake()
    {
        // Here, we just make sure there is only one instance of this object in the map.
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    #endregion

    #region On sphere item events
    /*
     * Binds to on sphere pickup event.
     * @param incomingMethod Method to bind.
     */
    public void BindToOnSphereItemPickup(OnSphereItemPickedUp incomingMethod)
    {
        onSphereItemPickedUp += incomingMethod;
    }

    /*
     * Unbind from on sphere item pickup.
     * @param outgoingMethod Method to unbind.
     */
    public void UnbindToOnSphereItemPickup(OnSphereItemPickedUp outgoingMethod)
    {
        if(onSphereItemPickedUp != null) onSphereItemPickedUp -= outgoingMethod;
    }

    /*
     * Calls the on sphere item pickup event.
     */
    public void CallOnSphereItemPickupEvent()
    {
        if(onSphereItemPickedUp != null) onSphereItemPickedUp.Invoke();
    }

    /*
     * Binds to on sphere item drop event.
     * @param incomingMethod Method to bind.
     */
    public void BindToOnSphereItemDrop(OnSphereItemDrop incomingMethod)
    {
        onSphereItemDrop += incomingMethod;
    }

    /*
     * Unbind from on sphere item drop.
     * @param outgoingMethod Method to unbind.
     */
    public void UnbindToOnSphereItemDrop(OnSphereItemDrop outgoingMethod)
    {
        if(onSphereItemDrop != null) onSphereItemDrop -= outgoingMethod;
    }

    /*
     * Calls the on sphere item drop event.
     */
    public void CallOnSphereItemDropEvent()
    {
        if(onSphereItemDrop != null) onSphereItemDrop.Invoke();
    }
    #endregion

    #region Reset events
    /*
     * Binds to on event reset.
     * @param incomingMethod Method to bind.
     */
    public void BindToOnResetEvents(OnEventsReset incomingMethod)
    {
        onEventsReset += incomingMethod;
    }

    /*
     * Unbinds from on event reset.
     * @param outgoingMethod Method to unbind.
     */
    public void UnbindToOnResetEvents(OnEventsReset outgoingMethod)
    {
        if (onEventsReset != null) onEventsReset -= outgoingMethod;
    }

    /*
     * Calls the on event reset.
     */
    public void CallOnOnResetEvents()
    {
        if (onEventsReset != null) onEventsReset.Invoke();
    }
    #endregion
}