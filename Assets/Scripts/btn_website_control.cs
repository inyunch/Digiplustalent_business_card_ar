using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn_website_control : MonoBehaviour
{
    
    public string Url;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Open()
    {
        Application.OpenURL(Url);
        //Debug.Log("is this working?");
    }
}
