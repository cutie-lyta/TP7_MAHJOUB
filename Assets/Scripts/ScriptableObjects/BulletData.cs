using UnityEngine;

[CreateAssetMenu(fileName = "Bullet", menuName = "Object/Bullet")]
public class BulletData : ScriptableObject
{
    public float Speed;
    public int Damage;
    public float Range;

    public GameObject Prefab;
}
