using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGameItem : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject resetPosition;

    [SerializeField]
    private GameObject sphereItem;

    [SerializeField]
    private GameObject sphereItemDefaultLocation;
    #endregion

    #region Common logic
    // Start is called before the first frame update.
    private void Start()
    {
        LevelManager.Instance.BindToOnResetEvents(ResetGameLogic);
    }

    // Update is called once per frame.
    private void Update()
    {
        
    }
    #endregion

    #region Public logic
    public void OnResetGame()
    {
        LevelManager.Instance.CallOnOnResetEvents();
    }
    #endregion

    #region Private logic
    private void ResetGameLogic()
    {
        player.transform.position = resetPosition.transform.position;
        sphereItem.transform.position = sphereItemDefaultLocation.transform.position;
    }
    #endregion
}