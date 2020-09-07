using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class urlbtn: MonoBehaviour
{

    public string Url;
    // Start is called before the first frame update
    public void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(Onclick);

    }
    public void Onclick()
    {
        Application.OpenURL(Url);
        //Debug.Log("is this working?");
    }
    void Update()
    {
        
    }

}