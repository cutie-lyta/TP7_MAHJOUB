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

    void CreateBullet(){
        _timer = _shootSpeed;

        var _ballType = _bulletData.Prefab;
        var go = Instantiate(_ballType).GetComponent<BulletBehaviour>();

        var mousePos = Input.mousePosition;
        var mousePosition = _camera.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, _camera.nearClipPlane));
        mousePosition.z = 0f;
        var dir = mousePosition - transform.position;

        print($"{mousePosition}");
        print($"{transform.position}");
        go._data = _bulletData;

        go.transform.position = transform.position;
        go.transform.LookAt(dir);

        go.gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.right*_shootSpeed*3, ForceMode2D.Impulse);
    }
}
