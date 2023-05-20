using UnityEngine;
using UnityEngine.UI;

public class PhoneButton : MonoBehaviour
{
    public string contactNumber;

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OpenPhoneDialer);
    }

    private void OpenPhoneDialer()
    {
        string url = "tel:" + contactNumber;
        Application.OpenURL(url);
    }
}
