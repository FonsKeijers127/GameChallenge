using UnityEngine;

public class ToggleLight : MonoBehaviour
{
    [SerializeField] Light l;
    [SerializeField] AudioClip lightOn;
    [SerializeField] AudioClip lightOff;
    [SerializeField] AudioSource audioSource;
    public void OnMouseDown()
    {
        l.enabled = !l.enabled;
            if (l.enabled)
            {
                audioSource.PlayOneShot(lightOn);
            }
            else
            {
                if (lightOff == null) return;
                audioSource.PlayOneShot(lightOff);
            } 
            }
    }

