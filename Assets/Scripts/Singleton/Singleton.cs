using UnityEngine;

public class Singleton<T> : SingletonBase where T : MonoBehaviour
{
    public static T Instance { get; private set; }

    private protected void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance.gameObject);
            return;
        }
        else
        {
            Instance = GetComponent<T>();
            DontDestroyOnLoad(gameObject);
        }
    }
}
