using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    private float _shootSpeed;
    private BulletData _bulletData;
    private float _timer = 0.0f;
    private Camera _camera;

    private void Awake(){
        _shootSpeed = GetComponent<PlayerMain>().Data.ShootRate;
        _bulletData = GetComponent<PlayerMain>().Data.DefaultBulletData;
        _camera = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       if(Input.GetMouseButton(0)){
           if(_timer <= 0.0f){
               CreateBullet();
           }
       } 

       _timer -= Time.fixedDeltaTime * 10;
    }

    void CreateBullet()
    {
        _timer = _shootSpeed;

        Vector3 playerPos = transform.position;
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;
        Vector3 direction = mousePos - playerPos;

        float time = _bulletData.Range * 2;

        var projectile = Instantiate(_bulletData.Prefab);
        projectile.GetComponent<BulletBehaviour>()._creator = "Player";
        projectile.GetComponent<BulletBehaviour>()._data = _bulletData;
        projectile.transform.position = playerPos;
        Rigidbody2D rbProjectile = projectile.GetComponent<Rigidbody2D>();
        rbProjectile.AddForce(direction * _bulletData.Speed, ForceMode2D.Impulse);
        Destroy(projectile, time);
         
    }
}
