using UnityEngine;
using TMPro;
using Ink.Runtime;

public class DialogueSystem : MonoBehaviour
{
	[SerializeField]
	private TextAsset inkJSONAsset = null;
	public Story story;

	[SerializeField]
	private Canvas canvas = null;

	// UI Prefabs
	[SerializeField]
	private TextMeshProUGUI textPrefab = null;
	[SerializeField]
	private TextMeshProUGUI buttonPrefab = null;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
