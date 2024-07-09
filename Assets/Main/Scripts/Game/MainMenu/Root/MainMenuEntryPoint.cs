using System;
using UnityEngine;

public class MainMenuEntryPoint : MonoBehaviour
{
    [SerializeField] private UIMainMenuRootBinder _sceneUIRootPrefab;

    public event Action GoToGameplaySceneRequested;

    public void Run(UIRootView uIRoot)
    {
        var uiScene = Instantiate(_sceneUIRootPrefab);
        uIRoot.AttachSceneUI(uiScene.gameObject);

        uiScene.GoToGameplayButtonClick += () =>
        {
            GoToGameplaySceneRequested?.Invoke();
        };
    }
}