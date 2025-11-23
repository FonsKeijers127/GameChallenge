using UnityEngine;

public class EnableFaucet : MonoBehaviour
{
   [SerializeField] ParticleSystem particles;
   [SerializeField] bool isActivated = false;

    /*void Update()
    {
       
        if (isActivated)
        {
            particles.Play();
        } else
        {
            particles.Stop();
        }
    }*/
    public void OnMouseDown()
    {
        isActivated = !isActivated;
        if(isActivated)
        {
         particles.Play();
        }
        else
        {
            particles.Stop();
        }
    }
}
