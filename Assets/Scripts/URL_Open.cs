using System.Collections;
using UnityEngine;

public class URL_Open : MonoBehaviour
{
    public string url;
    public void Url_Open(string url)
    {
        Application.OpenURL(url);
    }
}
