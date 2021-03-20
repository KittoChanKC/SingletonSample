using UnityEngine;

public class SingletonSample : Singleton<SingletonSample>
{
    [SerializeField] private string helloWords = "I'm now awaken.";

    private new void Awake()
    {
        base.Awake();

        print($"{gameObject.name} : {helloWords}");
    }
}
