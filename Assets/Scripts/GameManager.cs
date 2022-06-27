using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _localAvatarPrefab;

    private GameObject _player;

    void Start()
    {
        var components = _localAvatarPrefab.GetComponents(typeof(Component));
        foreach(Component component in components)
        {
            Debug.Log($"Component: {component.ToString()}");
        }

    }

    void FixedUpdate()
    {
        
    }
}
