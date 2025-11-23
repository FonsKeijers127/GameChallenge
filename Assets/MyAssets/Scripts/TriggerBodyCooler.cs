using UnityEngine;

public class TriggerBodyCooler : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Animator bodyAnimator;
    [SerializeField] Animator bodyClothAnimator;

    private void OnMouseDown() {
        animator.SetTrigger("_playAnimation");
        bodyAnimator.SetTrigger("_playAnimation");
        bodyClothAnimator.SetTrigger("playAnimation");
    }
}
