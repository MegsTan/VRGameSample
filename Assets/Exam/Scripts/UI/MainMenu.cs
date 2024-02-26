using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    #region Variables
    public static MainMenu Instance;

    [SerializeField]
    private GameObject[] SubMenu;
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

    #region Public logic
    public void InitializeSubMenu()
    {
        ResetAllSubMenu();
        SubMenu[0].SetActive(true);
    }


    public void OnWeaponButtonClicked()
    {
        ResetAllSubMenu();
        SubMenu[0].SetActive(true);
    }

    public void OnPointsButtonClicked()
    {
        ResetAllSubMenu();
        SubMenu[1].SetActive(true);
    }

    public void OnInstrumentsButtonClicked()
    {
        ResetAllSubMenu();
        SubMenu[2].SetActive(true);
    }

    public void OnCloseMainMenu()
    {
        gameObject.SetActive(false);
    }
    #endregion

    #region Private logic
    private void ResetAllSubMenu()
    {
        // Reset all menus.
        for (int i = 0; i < SubMenu.Length; i++)
        {
            SubMenu[i].SetActive(false);
        }
    }
    #endregion
}
