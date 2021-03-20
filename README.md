# SingletonSample

A Sample of Singleton.

Handling singleton with single scene is very simple.

Handling singleton as DontDestoryObject is not so simple.


This is a very simple idea for handling singleton as DontDestoryObject.

1) class SingletonSample : Singleton<SingletonSample>
    - make any singleton class like this
   
2) class Singleton<T> : SingletonBase where T : MonoBehaviour
    - destroy other same T in the hierarchy automatically
    - set single static T Instance { get; private set; }
    
3) class SingletonBase : MonoBehaviour
    - public virtual void SceneInit() for initialize on scene load
    
4) SingletonLoader
    - exists on every scene
    - handle existing singletons
    - build not existing singletons
    - run SceneInit();
    - destroy self automatically
    
Setup is simple.

Make all your singleton gameobjects as prefabs.

Setup the list on SingletonLoader.

Make the SingletonLoader as prefab.

You need no singletone gameobjects in the scene but only one SingletonLoader in every scene.

Please refer to the SampleScene in Assets.
