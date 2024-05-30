using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bird : MonoBehaviour
{
    [SerializeField] private Score _score;
    [SerializeField] private GameLoop _gameLoop;
    [Space(10), SerializeField] private float _jumpForce;

    private Rigidbody2D _birdRigidbody;

    private void Start() => _birdRigidbody = GetComponent<Rigidbody2D>();

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            _birdRigidbody.velocity = Vector2.up * _jumpForce;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Tower>(out Tower tower))
            _gameLoop.EndGameLoop();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<ScoreZone>(out ScoreZone scoreZone))
            _score.AddScore();
    }
}