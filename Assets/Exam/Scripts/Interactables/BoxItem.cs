using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class BoxItem : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private UnityEvent triggerEvent;

    [SerializeField]
    private bool hideObjectOnEnter = false;
    #endregion

    #region Events
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SphereItem")
        {
            triggerEvent.Invoke();

            if(hideObjectOnEnter)
            {
                other.gameObject.SetActive(false);
                MainMenu.Instance.OnCloseMainMenu();
                SphereItem.Instance.IsItemDroppedInTheBox = true;
            }
        }
    }
    #endregion
}
