using System;
using UnityEngine;

public class GameplayEntryPoint : MonoBehaviour
{
    [SerializeField] private UIGameplayRootBinder _sceneUIRootPrefab;

    public event Action GoToMainMenuSceneRequested;

    public void Run(UIRootView uIRoot)
    {
        var uiScene = Instantiate(_sceneUIRootPrefab);
        uIRoot.AttachSceneUI(uiScene.gameObject);
        uiScene.GoToMainMenuButtonClick += () =>
        {
            GoToMainMenuSceneRequested?.Invoke();
        };
    }
}
