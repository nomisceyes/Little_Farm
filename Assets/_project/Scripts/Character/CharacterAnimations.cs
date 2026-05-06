using UnityEngine;

public class CharacterAnimations : MonoBehaviour
{
    public Mover Mover;
    public Animator Animator;
    
    private void Update()
    {
        if (Mover.MoveDirection != Vector2.zero)
        {
            Animator.SetBool("IsMoving", true);
            Animator.SetFloat("MoveX", Mover.MoveDirection.x);
            Animator.SetFloat("MoveY", Mover.MoveDirection.y);
        }
        else
        {
            Animator.SetBool("IsMoving", false);
        }
    }
}