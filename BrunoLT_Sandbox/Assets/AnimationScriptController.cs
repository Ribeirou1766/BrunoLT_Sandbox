using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationStateController : MonoBehaviour
{
    [Header("Animator")]
    public Animator animator;

    [Header("Input Action (Vector2)")]
    // Drag your "Move" action (Vector2) here from the Input Actions asset
    public InputActionReference moveAction;

    private void OnEnable()
    {
        moveAction.action.Enable();
    }

    private void OnDisable()
    {
        moveAction.action.Disable();
    }

    private void Update()
    {
        Vector2 input = moveAction.action.ReadValue<Vector2>();

        // When pressing W (or any direction), input != Vector2.zero
        bool isWalking = input.sqrMagnitude > 0.01f;

        animator.SetBool("IsWalking", isWalking);
    }
}
