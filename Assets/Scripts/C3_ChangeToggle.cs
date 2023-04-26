using UnityEngine;
using UnityEngine.UI;

public class C3_ChangeToggle : C_ChangeToggle
{
    [SerializeField] Toggle toggleToDisable1;
    protected override void ChangeToggle()
    {
        if (enabledToggle.isOn)
        {
            toggleToDisable.isOn = false;
            toggleToDisable1.isOn = false;
        }
    }
}
