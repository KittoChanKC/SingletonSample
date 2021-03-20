using System.Collections.Generic;
using UnityEngine;

public class SingletonLoader : MonoBehaviour
{
    [SerializeField] private bool destroyAfterBuilt = true;
    [SerializeField] private List<SingletonBase> singletons;
    private readonly List<string> existingSingletons = new List<string>();

    private void Awake()
    {
        HandleExistingSingletons();
        BuildNewSingletons();
    }

    private void HandleExistingSingletons()
    {
        existingSingletons.Clear();

        foreach (var singleton in FindObjectsOfType<SingletonBase>())
        {
            existingSingletons.Add(singleton.gameObject.name);
            singleton.SceneInit();
        }
    }

    private void BuildNewSingletons()
    {
        foreach (var singleton in singletons)
        {
            if (existingSingletons.Contains(singleton.gameObject.name)) continue;

            var go = Instantiate(singleton.gameObject, Vector3.zero, Quaternion.identity, null);
            go.name = singleton.gameObject.name;
            go.GetComponent<SingletonBase>().SceneInit();
        }

        if (destroyAfterBuilt)
            Destroy(gameObject);
    }
}
