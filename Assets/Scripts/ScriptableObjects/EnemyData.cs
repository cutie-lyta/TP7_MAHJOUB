using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "Object/Enemy")]
public class EnemyData : ScriptableObject
{
    public int Health;
    public float Speed;
    public float ShootRate;

    public float MoveThreshold;
    public float ShootThreshold;

    public GameObject Prefab;
    public BulletData BulletData;
}
