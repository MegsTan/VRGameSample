using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereItemEvent : MonoBehaviour
{
    #region Variables

    #endregion

    #region Events
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") SphereItem.Instance.OnInsideTheTrigger();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") SphereItem.Instance.OnOutOfTrigger();
    }
    #endregion
}
