using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent nav;
    [SerializeField]
    public Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        nav.SetDestination(player.position);
    }
}
