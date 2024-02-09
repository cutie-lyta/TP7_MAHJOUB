using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance {get; private set;}

    [SerializeField] public CharacterData CharData;

    public void Awake(){
        if(Instance != null){
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void StartGame(){
        GameObject obj = Instantiate(CharData.Prefab);
    }
}
