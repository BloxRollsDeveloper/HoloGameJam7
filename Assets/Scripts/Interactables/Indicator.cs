using UnityEngine;

public class Indicator : MonoBehaviour
{
    public GameObject starIndicator;

    private void Start()
    {
        if (starIndicator != null)
        {
            starIndicator.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            starIndicator.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            starIndicator.SetActive(false);
        }
    }
}
