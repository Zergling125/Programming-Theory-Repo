using UnityEngine;
using UnityEngine.UI;

//INHERITANCE
public class EApplyButton : AApplyButton
{
    [SerializeField] Toggle middleToggle;

    //POLYMORPHISM
    protected override void CheckAnswers()
    {
        if (rightToggle.isOn)
        {
            wrongText.SetActive(true);
            wrongButton.SetActive(true);
            applyButton.SetActive(false);
        }
        else if (leftToggle.isOn)
        {
            wrongText.SetActive(true);
            wrongButton.SetActive(true);
            applyButton.SetActive(false);
        }
        else if (middleToggle.isOn)
        {
            rightText.SetActive(true);
            rightButton.SetActive(true);
            applyButton.SetActive(false);
            main.isQ4Ans = true;
        }
    }
}
