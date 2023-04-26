using UnityEngine.UI;
using UnityEngine;


//INHERITANCE
public class WrongButton : RightButton
{
    [SerializeField] Button button;
    private Main main;

   
    private void Start()
    {
        main = GameObject.Find("Main").GetComponent<Main>();
    }
    //POLYMORPHISM
    public override void SetScreen()
    {
        base.SetScreen();
        button.image.color = Color.red;
        main.qNum += 1;
    }
}
