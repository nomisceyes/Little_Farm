using UnityEngine;

public class CharacterAnimations : MonoBehaviour
{
    public Animator Animator;

    public Mover Mover;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Mover.MoveDirection != Vector2.zero)
        {
            Animator.SetBool(CharacterAnimationParameter.IsMoving, true);
            Animator.SetFloat(CharacterAnimationParameter.MoveX, Mover.MoveDirection.x);
            Animator.SetFloat(CharacterAnimationParameter.MoveY, Mover.MoveDirection.y);
        }
        else
        {
            Animator.SetBool(CharacterAnimationParameter.IsMoving, false);
        }
    }
}

public static class CharacterAnimationParameter
{
    public static readonly int MoveX = Animator.StringToHash("MoveX");
    public static readonly int MoveY = Animator.StringToHash("MoveY");
    public static readonly int IsMoving = Animator.StringToHash("IsMoving");
}