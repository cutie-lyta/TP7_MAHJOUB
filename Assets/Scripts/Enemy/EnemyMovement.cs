using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(EnemyMain))]
public class EnemyMovement : MonoBehaviour
{
    private float _speed;
    private Rigidbody2D _rb;
    private EnemyAI _ai;
    private EnemyMain _main;
    

    private void Awake(){
        _ai = GetComponent<EnemyAI>();
        _rb = GetComponent<Rigidbody2D>();
        _main = GetComponent<EnemyMain>();

        _speed = _main.Data.Speed;
    }

    private void FixedUpdate(){
        if(_ai.shouldMove){
            Vector3 movement = new Vector3 (1.0f, 0.0f, 0.0f);
            movement = movement.normalized * _speed * Time.deltaTime;
            _rb.MovePosition(transform.localPosition + movement);
        }        
    }
}
