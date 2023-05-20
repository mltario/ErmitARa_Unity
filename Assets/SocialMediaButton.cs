using UnityEngine;
using UnityEngine.UI;

public class SocialMediaButton : MonoBehaviour
{
    public string apiLink;

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OpenSocialMediaAPI);
    }

    private void OpenSocialMediaAPI()
    {
        Application.OpenURL(apiLink);
    }
}
