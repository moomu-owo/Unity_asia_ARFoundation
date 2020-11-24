
using UnityEngine;
using UnityEngine.XR.ARFoundation;  //引用ARFoundation API
using System.Collections.Generic;  //引用系統 一般 集合

/// <summary>
/// 點擊地面生成物件
/// </summary>
//RC要求原件:在第一次套用腳本時執行
[RequireComponent(typeof(ARRaycastManager))]
public class ARManager : MonoBehaviour
{
    [Header("點擊後要生成的物件")]
    public GameObject obj;
    [Header("AR管理器")]
    public ARRaycastManager armanager;

    //滑鼠座標
    private Vector2 pointMouse;
    //碰撞資訊
    private List<ARRaycastHit> hits;

}
