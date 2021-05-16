
using UnityEngine;

public class OpenUrl : MonoBehaviour
{
    public string URL;

    public void Open()
    {
        Application.OpenURL(URL);
    }
}
