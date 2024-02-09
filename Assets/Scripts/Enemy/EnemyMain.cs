
using UnityEngine;

[RequireComponent(typeof(EnemyMovement))]
[RequireComponent(typeof(EnemyShoot))]
[RequireComponent(typeof(EnemyAI))]
public class EnemyMain : MonoBehaviour
{
   private int _health;
   [HideInInspector] public EnemyData Data;

   public void Init(EnemyData data){
       Data = data;
   }

   public void TakeDamage(int damage){
      _health -= damage;
   }
}
