using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rb;

    public float Speed = 200.0f;

    public ScoreManager ScoreManager;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    public void Start()
    {
        AddStartingForce();
    }

    private void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1f : 1f;
        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f) :
                                        Random.Range(0.5f, 1f);

        Vector2 direction = new Vector2(x, y).normalized;
        _rb.AddForce(direction * Speed, ForceMode2D.Impulse);
    }

    public void AddForce(Vector2 force)
    {
        _rb.AddForce(force);
    }

    public void ResetPosition()
    {
        _rb.velocity = Vector3.zero;
        _rb.position = Vector3.zero;

        AddStartingForce();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
         if (collision.gameObject.name == "Right Wall")
        {
            ScoreManager.PlayerGoal();
        }
        
           else if (collision.gameObject.name == "Left Wall")
        {
            ScoreManager.ComputerGoal(); 
        }
     
    }
}
