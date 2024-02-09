using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BulletBehaviour : MonoBehaviour
{
    public BulletData _data {private get; set;}
    public string _creator { private get; set;}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player") && this._creator != "Player")
        {
            col.gameObject.GetComponent<PlayerMain>().TakeDamage(this._data.Damage);
        }
        else if (col.gameObject.CompareTag("Enemy") && this._creator != "Enemy")
        {
            col.gameObject.GetComponent<EnemyMain>().TakeDamage(this._data.Damage);
        }

        Destroy(this.gameObject);
    }
}
