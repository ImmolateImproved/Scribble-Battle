using System;
using UnityEngine;

public class UIGameplayRootBinder : MonoBehaviour
{
    public event Action GoToMainMenuButtonClick;

    public void HandleGoToMainMenuButtonClick()
    {
        GoToMainMenuButtonClick?.Invoke();
    }
}
