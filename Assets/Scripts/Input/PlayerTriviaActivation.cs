using UnityEngine;

public class PlayerTriviaActivation : MonoBehaviour
{
    private InputBehaviourSystem _input;
    
    public GameObject talentTrivia;

    private void Start()
    {
        _input = GetComponent<InputBehaviourSystem>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Trivia") && _input.Interact)
        {
            print("penaur");
            talentTrivia.SetActive(true);
        }
    }
}
