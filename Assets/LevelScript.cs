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
        switch (GlobalManager.data.Level) {
            case 1:
                if (GlobalManager.data.Money < 33) {
                    GetComponent<Image>().sprite = zero;
                }
                else if (GlobalManager.data.Money <= 67) {
                    GetComponent<Image>().sprite = one;
                }
                else if (GlobalManager.data.Money <= 100) {
                    GetComponent<Image>().sprite = two;
                }
                else if (GlobalManager.data.Money <= 133) {
                    GetComponent<Image>().sprite = three;
                }
                else if (GlobalManager.data.Money <= 167) {
                    GetComponent<Image>().sprite = four;
                }
                else if (GlobalManager.data.Money <= 199) {
                    GetComponent<Image>().sprite = five;
                }
                else {
                    GetComponent<Image>().sprite = six;
                }
                break;
            default:
                if (GlobalManager.data.Money <= 67 * GlobalManager.data.Level) {
                    GetComponent<Image>().sprite = one;
                }
                else if (GlobalManager.data.Money <= 133 * GlobalManager.data.Level) {
                    GetComponent<Image>().sprite = two;
                }
                else if (GlobalManager.data.Money <= 200 * GlobalManager.data.Level) {
                    GetComponent<Image>().sprite = three;
                }
                else if (GlobalManager.data.Money <= 267 * GlobalManager.data.Level) {
                    GetComponent<Image>().sprite = four;
                }
                else if (GlobalManager.data.Money <= 333 * GlobalManager.data.Level) {
                    GetComponent<Image>().sprite = five;
                }
                else if (GlobalManager.data.Money >= 399 * GlobalManager.data.Level) {
                    GetComponent<Image>().sprite = six;
                } 
                break;
        }
    }
}
