using UnityEngine;
using System.Collections.Generic;

public class GameSceneData : MonoBehaviour
{
    [SerializeField] private List<EnemyData> Enemies; 
    [SerializeField] private float _rate;

    private float _timer = 0.0f;

    void Start(){
        GameManager.Instance.StartGame();
    }

    void FixedUpdate(){
        if(_timer <= 0){
            var enemy = Enemies[Random.Range(0, Enemies.Count)];
            

            float spawnY = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
            float spawnX = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);

            Instantiate(enemy.Prefab, new Vector2(spawnX, spawnY), Quaternion.Euler(0, 0, 0));
        }

        _timer -= Time.fixedDeltaTime;
    }
}
