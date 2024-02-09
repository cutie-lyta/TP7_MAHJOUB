using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BulletBehaviour : MonoBehaviour
{
   public BulletData _data {private get; set;}

   void OnCollisionEnter2D(Collision2D col){
      if(col.gameObject.CompareTag("Player")){
         col.gameObject.GetComponent<PlayerMain>().TakeDamage(_data.Damage);
      } else if (col.gameObject.CompareTag("Enemy")){
         col.gameObject.GetComponent<EnemyMain>().TakeDamage(_data.Damage);
      }

      Destroy(this.gameObject);
   }
}
