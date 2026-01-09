using UnityEngine;

public class PairsManager : MonoBehaviour
{
    public static PairsManager Instance;
    [SerializeField] private LineRenderer draggingLine;
    private Card _draggingCard;
    
    private void Awake()
    {
        Instance = this;
    }
}
