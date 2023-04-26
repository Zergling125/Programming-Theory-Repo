using UnityEngine;
using UnityEngine.UI;

public class AApplyButton : MonoBehaviour
{
    [SerializeField] protected Toggle leftToggle;
    [SerializeField] protected Toggle rightToggle;
    [SerializeField] protected GameObject rightText;
    [SerializeField] protected GameObject wrongText;
    [SerializeField] protected GameObject rightButton;
    [SerializeField] protected GameObject wrongButton;
    [SerializeField] protected GameObject applyButton;
    [SerializeField] protected Main main;

    protected virtual void CheckAnswers()
    {
        if (rightToggle.isOn)
        {
            wrongText.SetActive(true);
            wrongButton.SetActive(true);
            applyButton.SetActive(false);

        }
        else if (leftToggle.isOn)
        {
            rightText.SetActive(true);
            rightButton.SetActive(true);
            applyButton.SetActive(false);
            main.isQ1Ans = true;
        }
    }
}
