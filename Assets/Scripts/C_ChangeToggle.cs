using UnityEngine;
using UnityEngine.UI;

public class C_ChangeToggle : MonoBehaviour
{
    [SerializeField] protected Toggle toggleToDisable;
    [SerializeField] protected Toggle enabledToggle;
    protected virtual void ChangeToggle()
    {
        if (enabledToggle.isOn)
        {
            toggleToDisable.isOn = false;
        }
    }
}
