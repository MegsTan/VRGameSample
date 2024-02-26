using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpatialPanel : MonoBehaviour
{
    #region Variables
    // Your target camera.
    private GameObject TargetCamera;
    #endregion
    
    #region Common logic
    // Start is called before the first frame update.
    private void Start()
    {
        if (Camera.main.gameObject != null) TargetCamera = Camera.main.gameObject;
    }

    // Update is called once per frame.
    private void Update()
    {
        if (TargetCamera != null)
        {
            transform.LookAt(TargetCamera.transform.position);
        }
    }
    #endregion
}