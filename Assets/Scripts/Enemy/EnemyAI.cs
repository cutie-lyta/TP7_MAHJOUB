using UnityEngine;

[RequireComponent(typeof(EnemyMain))]
[RequireComponent(typeof(Rigidbody2D))]
public class EnemyAI : MonoBehaviour
{
    
    private PlayerMain _player;
    private EnemyMain _main;
    private Rigidbody2D _rb;

    public bool shouldMove;
    public bool shouldShoot;

    void Awake(){
        _rb = GetComponent<Rigidbody2D>();
        _main = GetComponent<EnemyMain>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Should be called once, if not, it means the player took time to spawn, but it's at least caught
        if(_player == null){
            _player = FindObjectOfType<PlayerMain>();
            return;
        }
        
        transform.LookAt(_player.transform);

        var dist = Vector2.Distance(this.transform.position, _player.transform.position);
        shouldMove = true;
        shouldShoot = false;
        if(dist <= _main.Data.MoveThreshold){
            shouldMove = false;
        }
        if(dist <= _main.Data.ShootThreshold){
            shouldShoot = true;
        }
            
    }
}
