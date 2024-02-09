
using UnityEngine;

[RequireComponent(typeof(EnemyMovement))]
[RequireComponent(typeof(EnemyShoot))]
[RequireComponent(typeof(EnemyAI))]
[RequireComponent(typeof(BoxCollider2D))]
public class EnemyMain : MonoBehaviour
{
   private int _health;
   [HideInInspector] public EnemyData Data;

   public void Init(EnemyData data){
       Data = data;
   }

   public void TakeDamage(int damage){
      _health -= damage;
      if(_health <= 0){
         Destroy(this.gameObject);
      }
   }
}
