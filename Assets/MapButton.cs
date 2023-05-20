using UnityEngine;
using UnityEngine.UI;

public class MapButton : MonoBehaviour
{
    public float latitude;
    public float longitude;

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OpenGoogleMaps);
    }

    private void OpenGoogleMaps()
    {
        string coordinates = latitude.ToString() + "," + longitude.ToString();
        string url = "https://www.google.com/maps/search/?api=1&query=" + coordinates;
        Application.OpenURL(url);
    }
}
