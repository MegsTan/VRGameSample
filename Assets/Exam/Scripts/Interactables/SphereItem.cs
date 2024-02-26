using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SphereItem : MonoBehaviour
{
    #region Variables
    public static SphereItem Instance;

    [SerializeField]
    private Animation SpatialPanelAnimation;
    [SerializeField]
    private Animation MainMenuAnimation;

    private bool IsItemPickedUp = false;

    [HideInInspector]
    public bool IsItemDroppedInTheBox = false;
    #endregion

    #region Common logic
    // Awake is called before start.
    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update.
    private void Start()
    {
        IsItemPickedUp = false;
        LevelManager.Instance.BindToOnSphereItemPickup(OnActivateMainMenu);
        LevelManager.Instance.BindToOnSphereItemDrop(OnDeactivateMainMenu);
    }
    #endregion

    #region Public logic
    /*
     * Is called by the event when the item has been picked up.
     */
    public void OnItemPickup()
    {
        // Calls the on sphere item pickup, will invoke all subscribed event to it.
        LevelManager.Instance.CallOnSphereItemPickupEvent();

        if (!IsItemPickedUp) IsItemPickedUp = true;
    }

    /*
     * Is called by the event when the item has been dropped.
     */
    public void OnItemDrop()
    {        
        // Calls the on sphere item drop, will invoke all subscrubed event to it.
        LevelManager.Instance.CallOnSphereItemDropEvent();
    }

    public void OnOutOfTrigger()
    {
        SpatialPanelAnimation.gameObject.SetActive(false);
        MainMenuAnimation.gameObject.SetActive(false);
    }

    public void OnInsideTheTrigger()
    {
        if (IsItemDroppedInTheBox) return;

        SpatialPanelAnimation.gameObject.SetActive(true);
        MainMenuAnimation.gameObject.SetActive(true);

        if (IsItemPickedUp)
        {
            LevelManager.Instance.CallOnSphereItemPickupEvent();
        }
        else
        {
            LevelManager.Instance.CallOnSphereItemDropEvent();
        }
    }
    #endregion

    #region Events for sphere item
    /*
     * Activates main menu.
     */
    private void OnActivateMainMenu()
    {
        if(!IsItemPickedUp)
        {
            if (SpatialPanelAnimation != null) SpatialPanelAnimation.Play("FadeOut");
            if (MainMenuAnimation != null) MainMenuAnimation.Play("FadeIn");

            // Initialize main menu.
            MainMenu.Instance.InitializeSubMenu();
        }
        else
        {
            if (MainMenuAnimation != null) MainMenuAnimation.Play("FadeIn");

            // Initialize main menu.
            MainMenu.Instance.InitializeSubMenu();
        }
    }

    /*
     * Deactivates main menu.
     */
    private void OnDeactivateMainMenu()
    {
        if (MainMenuAnimation != null) MainMenuAnimation.Play("FadeOut");
    }
    #endregion
}