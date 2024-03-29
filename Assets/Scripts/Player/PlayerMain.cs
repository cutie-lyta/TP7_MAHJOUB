using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(PlayerShoot))]
public class PlayerMain : MonoBehaviour
{
   private int _health;
   private BulletData _bulletType;
   [HideInInspector] public CharacterData Data;

   public void TakeDamage(int damage){
      _health -= damage;
      if(_health <= 0){
         Destroy(this.gameObject);
      }
   }
}
