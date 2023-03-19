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
        levelText.text = "Level " + GlobalManager.data.Level.ToString();
    }
    
    public void Start()
    {
        ChangeImage();
    }

    public void ChangeImage()
    {
        if (GlobalManager.data.Money < 33)
        {
            GetComponent<Image>().sprite = zero;
        }
        else if (GlobalManager.data.Money >= 33 * GlobalManager.data.Level && GlobalManager.data.Money <= 67 * GlobalManager.data.Level && GlobalManager.data.Level == 1)
        {
            GetComponent<Image>().sprite = one;
        }
        else if (GlobalManager.data.Money >= 67 * GlobalManager.data.Level && GlobalManager.data.Money <= 100 * GlobalManager.data.Level && GlobalManager.data.Level == 1)
        {
            GetComponent<Image>().sprite = two;
        }
        else if (GlobalManager.data.Money >= 100 * GlobalManager.data.Level && GlobalManager.data.Money <= 133 * GlobalManager.data.Level && GlobalManager.data.Level == 1)
        {
            GetComponent<Image>().sprite = three;
        }
        else if (GlobalManager.data.Money >= 133 * GlobalManager.data.Level && GlobalManager.data.Money <= 167 * GlobalManager.data.Level && GlobalManager.data.Level == 1)
        {
            GetComponent<Image>().sprite = four;
        }
        else if (GlobalManager.data.Money >= 167 * GlobalManager.data.Level && GlobalManager.data.Money <= 199 * GlobalManager.data.Level && GlobalManager.data.Level == 1)
        {
            GetComponent<Image>().sprite = five;
        }
        else if (GlobalManager.data.Money >= 199 * GlobalManager.data.Level && GlobalManager.data.Level == 1)
        {
            GetComponent<Image>().sprite = six;
        }
        else if (GlobalManager.data.Money >= 67 * GlobalManager.data.Level && GlobalManager.data.Money <= 133 * GlobalManager.data.Level)
        {
            GetComponent<Image>().sprite = one;
        }
        else if (GlobalManager.data.Money >= 133 * GlobalManager.data.Level && GlobalManager.data.Money <= 100 * GlobalManager.data.Level)
        {
            GetComponent<Image>().sprite = two;
        }
        else if (GlobalManager.data.Money >= 200 * GlobalManager.data.Level && GlobalManager.data.Money <= 267 * GlobalManager.data.Level)
        {
            GetComponent<Image>().sprite = three;
        }
        else if (GlobalManager.data.Money >= 267 * GlobalManager.data.Level && GlobalManager.data.Money <= 333 * GlobalManager.data.Level)
        {
            GetComponent<Image>().sprite = four;
        }
        else if (GlobalManager.data.Money >= 333 * GlobalManager.data.Level && GlobalManager.data.Money <= 399 * GlobalManager.data.Level)
        {
            GetComponent<Image>().sprite = five;
        }
        else if (GlobalManager.data.Money >= 399 * GlobalManager.data.Level)
        {
            GetComponent<Image>().sprite = six;
        }
    }
}
