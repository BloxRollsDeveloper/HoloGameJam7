using UnityEngine;
using UnityEngine.InputSystem;

public class InputBehaviourSystem : MonoBehaviour
{
    private HoloJam _inputSystem;

    public float Horizontal;
    public bool Interact;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        _inputSystem = new HoloJam();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = _inputSystem.Player.Move.ReadValue<Vector2>().x;
        Interact = _inputSystem.Player.Interact.WasPressedThisFrame();
    }

	private void OnEnable()
	{
        _inputSystem.Enable();
	}

	private void OnDisable()
	{
		_inputSystem.Disable();
	}
}
