using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Object/Character")]
public class CharacterData : ScriptableObject
{
    public int Health;
    public float Speed;
    public float ShootRate;

    public GameObject Prefab;

    public BulletData DefaultBulletData;
}
