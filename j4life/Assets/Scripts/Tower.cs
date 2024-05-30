using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private void Update() => transform.Translate(-_moveSpeed * Time.deltaTime, 0, 0);
}