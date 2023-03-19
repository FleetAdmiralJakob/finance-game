using TMPro;
using UnityEngine;

public class IncreaseMoney : MonoBehaviour
{
    public TMP_Text moneyText;
    
    public void Start()
    {
        moneyText.text = "Money: $" + GlobalManager.data.Money.ToString();
    }

    public void Increase()
        {
            AudioManager audioManager = FindObjectOfType<AudioManager>();
            audioManager.PlayMoneySound();
            GlobalManager.data.Money += GlobalManager.data.Level * 2;
            moneyText.text = "Money: $" + GlobalManager.data.Money.ToString();
            if (GlobalManager.data.Money >= GlobalManager.data.Level * 200 && GlobalManager.data.Level == 1)
            {
                GlobalManager.data.Level++;
                GlobalManager.data.Money = 0;
            }
            else if (GlobalManager.data.Money >= GlobalManager.data.Level * 400)
            {
                GlobalManager.data.Level++;
                GlobalManager.data.Money = 0;
            }
            GlobalManager.SaveGame();
        }
}
