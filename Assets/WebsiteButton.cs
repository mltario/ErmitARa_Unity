using UnityEngine;
using UnityEngine.UI;

public class WebsiteButton : MonoBehaviour
{
    public string websiteLink;

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OpenWebsite);
    }

    private void OpenWebsite()
    {
        Application.OpenURL(websiteLink);
    }
}
