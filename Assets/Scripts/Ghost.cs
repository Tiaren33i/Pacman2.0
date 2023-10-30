using UnityEngine;

public class Ghost : MonoBehaviour
{
    public Movements movements { get; private set; }
    public GhostHome home { get; private set; }
    public GhostScatter scatter { get; private set; }
    public GhostChase chase { get; private set; }
    public GhostFrightened frightened { get; private set; }

    public GhostBehavior ghostBehavior ;

    public Transform target;

    public int points = 200;
    private void Awake()
    {
        this.movements=GetComponent<Movements>();
        this.home = GetComponent<GhostHome>();
        this.scatter = GetComponent<GhostScatter>();
        this.chase = GetComponent<GhostChase>();
        this.frightened = GetComponent<GhostFrightened>();
    }
    private void Start()
    {
        ResetState();
    }
    public void ResetState()
    {

    }
}
