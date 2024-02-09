using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerMain))]
public class PlayerMovement : MonoBehaviour
{
    private float _speed;
    private Rigidbody2D _rb;

    void Awake(){
        _rb = GetComponent<Rigidbody2D>();
        _speed = GetComponent<PlayerMain>().Data.Speed;
    }


    void FixedUpdate()
    {
        Vector3 dir = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        dir = dir * _speed * Time.fixedDeltaTime;

        _rb.MovePosition(this.transform.position + dir);
    }
}
