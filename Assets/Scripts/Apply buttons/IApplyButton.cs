public class IApplyButton : AApplyButton
{
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
            rightText.SetActive(true);
            rightButton.SetActive(true);
            applyButton.SetActive(false);
            main.isQ2Ans = true;
        }
    }
}

