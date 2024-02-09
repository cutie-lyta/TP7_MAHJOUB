using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BulletBehaviour : MonoBehaviour
{
    public BulletData _data {private get; set;} 

    public void Shoot()
    {
       GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(_data.Speed * 10, 0), ForceMode2D.Impulse); 
    }
}
