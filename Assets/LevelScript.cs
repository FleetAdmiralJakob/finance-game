using TMPro;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class LevelScript : MonoBehaviour
{
    public TMP_Text levelText;
    public Sprite zero;
    public Sprite one;
    public Sprite two;
    public Sprite three;
    public Sprite four;
    public Sprite five;
    public Sprite six;
    
    public void Update()
    {
        levelText.text = "Level " + GlobalManager.data.level.ToString();
    }
    
    public void Start()
    {
        ChangeImage();
    }

    public void ChangeImage()
    {
        if (GlobalManager.data.money == 0)
        {
            GetComponent<Image>().sprite = zero;
        }
        else if (GlobalManager.data.money >= 33 * GlobalManager.data.level && GlobalManager.data.money <= 67 * GlobalManager.data.level && GlobalManager.data.level == 1)
        {
            GetComponent<Image>().sprite = one;
        }
        else if (GlobalManager.data.money >= 67 * GlobalManager.data.level && GlobalManager.data.money <= 100 * GlobalManager.data.level && GlobalManager.data.level == 1)
        {
            GetComponent<Image>().sprite = two;
        }
        else if (GlobalManager.data.money >= 100 * GlobalManager.data.level && GlobalManager.data.money <= 133 * GlobalManager.data.level && GlobalManager.data.level == 1)
        {
            GetComponent<Image>().sprite = three;
        }
        else if (GlobalManager.data.money >= 133 * GlobalManager.data.level && GlobalManager.data.money <= 167 * GlobalManager.data.level && GlobalManager.data.level == 1)
        {
            GetComponent<Image>().sprite = four;
        }
        else if (GlobalManager.data.money >= 167 * GlobalManager.data.level && GlobalManager.data.money <= 199 * GlobalManager.data.level && GlobalManager.data.level == 1)
        {
            GetComponent<Image>().sprite = five;
        }
        else if (GlobalManager.data.money >= 199 * GlobalManager.data.level && GlobalManager.data.level == 1)
        {
            GetComponent<Image>().sprite = six;
        }
        else if (GlobalManager.data.money >= 67 * GlobalManager.data.level && GlobalManager.data.money <= 133 * GlobalManager.data.level)
        {
            GetComponent<Image>().sprite = one;
        }
        else if (GlobalManager.data.money >= 133 * GlobalManager.data.level && GlobalManager.data.money <= 100 * GlobalManager.data.level)
        {
            GetComponent<Image>().sprite = two;
        }
        else if (GlobalManager.data.money >= 200 * GlobalManager.data.level && GlobalManager.data.money <= 267 * GlobalManager.data.level)
        {
            GetComponent<Image>().sprite = three;
        }
        else if (GlobalManager.data.money >= 267 * GlobalManager.data.level && GlobalManager.data.money <= 333 * GlobalManager.data.level)
        {
            GetComponent<Image>().sprite = four;
        }
        else if (GlobalManager.data.money >= 333 * GlobalManager.data.level && GlobalManager.data.money <= 399 * GlobalManager.data.level)
        {
            GetComponent<Image>().sprite = five;
        }
        else if (GlobalManager.data.money >= 399 * GlobalManager.data.level)
        {
            GetComponent<Image>().sprite = six;
        }
    }
}
