public class PApplyButton : AApplyButton
{
    protected override void CheckAnswers()
    {
        if (rightToggle.isOn)
        {
            rightText.SetActive(true);
            rightButton.SetActive(true);
            applyButton.SetActive(false);
            main.isQ3Ans = true;
        }
        else if (leftToggle.isOn)
        {
            wrongText.SetActive(true);
            wrongButton.SetActive(true);
            applyButton.SetActive(false);
        }
    }
}

