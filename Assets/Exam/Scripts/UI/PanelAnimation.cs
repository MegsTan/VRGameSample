using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelAnimation : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private Animation panelAnimation;

    [SerializeField]
    private string animationName;
    #endregion

    #region Public logic
    /*
     * Animates the panel.
     */
    public void AnimatePanel()
    {
        panelAnimation.Play(animationName);
    }
    #endregion
}
