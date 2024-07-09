using UnityEngine;

public class UIRootView : MonoBehaviour
{
    [SerializeField] private GameObject loadingScreen;
    [SerializeField] private Transform _uiSceneContainer;

    private void Awake()
    {
        loadingScreen.SetActive(false);
    }

    public void ShowLoadingScreen()
    {
        loadingScreen.SetActive(true);
    }

    public void HideLoadingScreen()
    {
        loadingScreen.SetActive(false);
    }

    public void AttachSceneUI(GameObject sceneUI)
    {
        ClearSceneUI();
        sceneUI.transform.SetParent(_uiSceneContainer, false);
    }

    public void ClearSceneUI()
    {
        var childCount = _uiSceneContainer.childCount;

        for (int i = 0; i < childCount; i++)
        {
            Destroy(_uiSceneContainer.GetChild(i).gameObject);
        }
    }
}
