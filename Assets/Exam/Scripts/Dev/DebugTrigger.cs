using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTrigger : MonoBehaviour
{
    #region Variables
    #endregion

    #region Common logic
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Alpha1))
        {
            LevelManager.Instance.CallOnSphereItemPickupEvent();
        }
        else if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            LevelManager.Instance.CallOnSphereItemDropEvent();
        }
        else if (Input.GetKeyUp(KeyCode.Alpha6))
        {
            MainMenu.Instance.OnWeaponButtonClicked();
        }
        else if (Input.GetKeyUp(KeyCode.Alpha7))
        {
            MainMenu.Instance.OnPointsButtonClicked();
        }
        else if (Input.GetKeyUp(KeyCode.Alpha8))
        {
            MainMenu.Instance.OnInstrumentsButtonClicked();
        }
    }
    #endregion
}
