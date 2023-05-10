using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class MultipleKeys : MonoBehaviour
{
    [SerializeField] private Exit _exitFromLevel;
    [SerializeField] private Material _closedMaterial;
    [SerializeField] private Material _openMaterial;
    
    private MeshRenderer _renderer;
    public bool IsOpen { get; private set; }
    private int keyCount = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {   
            keyCount++;
            if(keyCount == 2)
                player.PickUpKey();

            Destroy(gameObject);
        }
    }

    private void Update()
    {
        LookAtPlayerInventory();
    }

    private void LookAtPlayerInventory()
    {
        if (keyCount == 2)
            _exitFromLevel.Open();
    }

    public void Open()
    {
        IsOpen = true;
        _renderer.sharedMaterial = _openMaterial;
    }
}

