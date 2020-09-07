using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gbshowbtn : MonoBehaviour
{ 
    GameObject gb;      //初始化
    //GameObject gb_2; 
    public string gbname;     //方便調用，循環利用
    //public string gbname_2; 
    public void Start() 
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(Onclick);
        
        gb = GameObject.Find(gbname);
        gb.active = true;   //設置開始可見性
        
        /*gb_2 = GameObject.Find(gbname_2);
        gb_2.active = false;   //設置開始可見性*/
    }
    public void Onclick() 
    {   //控制顯示和隱藏的方法
        
        if (gb.active == true)
        { 
            gb.SetActive(false);
        }
        else if (gb.active == false) 
        {
            gb.SetActive(true);
        }
        
    }
}
