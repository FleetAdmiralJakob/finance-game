using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip moneySound;
    private const float Volume = 0.1f;
    
    public void PlayMoneySound()
    {
        AudioSource.PlayClipAtPoint(moneySound, new Vector3(0, 0, 0), Volume);
    }

}
