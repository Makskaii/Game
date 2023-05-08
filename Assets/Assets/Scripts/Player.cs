using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class Player : MonoBehaviour
{
    public bool IsAlive { get; private set; } = true;
    public bool HasKey { get; private set; } = false;
    
    private PlayerMovement _movement;

    private void Awake()
    {
        _movement = GetComponent<PlayerMovement>();
    }

    private void Start()
    {
        Enable();
    }

    public void Enable()
    {
        _movement.enabled = true;
    }

    public void Disable()
    {
        _movement.enabled = false;
    }

    public void Kill()
    {
        IsAlive = false;
    }

    public void PickUpKey()
    {
        HasKey = true;
    }
}
