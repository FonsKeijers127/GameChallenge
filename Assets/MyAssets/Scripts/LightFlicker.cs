using UnityEngine;

public class LightFlicker : MonoBehaviour
{
   [SerializeField] Light myLight;
  // [SerializeField] float intensity = 5f;
   [SerializeField] float interval = 2f;
   [SerializeField] float maxWait = 1;
    [SerializeField] float maxFlicker = 0.2f;
    float timer;

    void Update()
    {
        timer += Time.deltaTime;
    if (timer > interval)
    {
        ToggleLight();
    }
}

    void ToggleLight()
    {
    myLight.enabled = !myLight.enabled;
    if (myLight.enabled)
    {
        interval = Random.Range(0, maxWait);
    }
    else 
    {
        interval = Random.Range(0, maxFlicker);
    }
    
    timer = 0;
    }
}
   

