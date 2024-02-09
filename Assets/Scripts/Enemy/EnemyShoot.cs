using UnityEngine;

[RequireComponent(typeof(EnemyAI))]
public class EnemyShoot : MonoBehaviour
{
    private EnemyAI _ai;
    private float _shootSpeed;
    private BulletData _bulletData;
    private float _timer = 0.0f;

    private void Start(){
        _shootSpeed = GetComponent<EnemyMain>().Data.ShootRate;
        _bulletData = GetComponent<EnemyMain>().Data.BulletData;
        _ai = GetComponent<EnemyAI>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       if(_ai.shouldShoot){
           if(_timer <= 0.0f){
               CreateBullet();
           }
       } 

       _timer -= Time.fixedDeltaTime * 10;
    }
    void CreateBullet(){
        _timer = _shootSpeed;

        var _ballType = _bulletData.Prefab;
        var go = Instantiate(_ballType);

        var _vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        go.transform.LookAt(_vector);
        go.GetComponent<BulletBehaviour>()._data = _bulletData;
        go.GetComponent<BulletBehaviour>()._creator = "Enemy";
    } 
}
