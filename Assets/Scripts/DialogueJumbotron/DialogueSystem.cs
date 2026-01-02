using Ink.Runtime;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{
	public static event Action<Story> OnCreateStory;
	private InputBehaviourSystem _inputSystem;


	[SerializeField] private TextAsset inkJSONAsset = null;
	public Story story;

	[SerializeField] private GameObject dialogueBox = null;

	// UI Prefabs
	[SerializeField] private TextMeshProUGUI dialogueTextPrefab = null;
	[SerializeField] private TextMeshProUGUI speakerTextPrefab = null;
	[SerializeField] private Button buttonPrefab = null;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Awake()
    {
		_inputSystem = GetComponent<InputBehaviourSystem>();

		story = new Story(inkJSONAsset.text);
		if (OnCreateStory != null) OnCreateStory(story);
		StartStory();
	}

    // Update is called once per frame
    void Update()
    {
		if (_inputSystem.Interact)
		{
			print("look at that, you did something.");
		}
    }

	public void StartStory()
	{
		// Display the text from the ink file
		// if it can't continue, then surely, it means that there is a choice available.
		while (story.canContinue)
		{
			string text = story.Continue();
			text = text.Trim();
			dialogueTextPrefab.text = text;
		}
		
		
		if (story.currentChoices.Count > 0)
		{
			for (int i = 0; i < story.currentChoices.Count; i++)
			{
				Choice choice = story.currentChoices[i];
				Button button = CreateChoices(choice.text.Trim());
				button.onClick.AddListener(delegate { OnClickChoiceButton(choice); });
			}
		}
		else
		{
			Button choice = CreateChoices("End of story.\nRestart?");
			choice.onClick.AddListener(delegate { StartStory(); });
		}
		
	}

	void OnClickChoiceButton(Choice choice)
	{
		story.ChooseChoiceIndex(choice.index);
	}

	Button CreateChoices(string text)
	{
		Button choice = Instantiate(buttonPrefab);
		choice.transform.SetParent(dialogueBox.transform, false);

		TextMeshProUGUI choiceText = choice.GetComponentInChildren<TextMeshProUGUI>();
		choiceText.text = text;

		// Make sure the button fits the text
		HorizontalLayoutGroup layoutGroup = choice.GetComponent<HorizontalLayoutGroup>();
		layoutGroup.childForceExpandHeight = false;

		return choice;
	}
}
