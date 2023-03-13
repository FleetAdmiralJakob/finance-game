using TMPro;
using UnityEngine;

public class IncreaseMoney : MonoBehaviour
{
    public TMP_Text moneyText;
    
    public void Start()
    {
        moneyText.text = "Money: $" + GlobalManager.data.money.ToString();
    }

    public void Increase()
        {
            GlobalManager.data.money += GlobalManager.data.level * 2;
            moneyText.text = "Money: $" + GlobalManager.data.money.ToString();
            if (GlobalManager.data.money >= GlobalManager.data.level * 200 && GlobalManager.data.level == 1)
            {
                GlobalManager.data.level++;
                GlobalManager.data.money = 0;
            }
            else if (GlobalManager.data.money >= GlobalManager.data.level * 400)
            {
                GlobalManager.data.level++;
                GlobalManager.data.money = 0;
            }
            GlobalManager.SaveGame();
        }
}
