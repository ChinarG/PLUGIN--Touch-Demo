using UnityEngine;
using HedgehogTeam.EasyTouch;//引用命名空间



/// <summary>
/// EasyTouch 4 版本的基本写法
/// </summary>
public class Easy4 : MonoBehaviour
{


    /// <summary>
    /// 在OnEnable中注册EasyTouch事件
    /// </summary>
    private void OnEnable()
    {
        //添加委托
        EasyTouch.On_TouchStart += OnTouchStart;
        EasyTouch.On_TouchUp += OnTouchEnd;
        EasyTouch.On_Swipe += OnTouchSwipe;
    }



    /// <summary>
    /// 在OnDisable中取消注册事件
    /// </summary>
    private void OnDisable()
    {
        //删除委托
        EasyTouch.On_TouchStart -= OnTouchStart;
        EasyTouch.On_TouchUp -= OnTouchEnd;
        EasyTouch.On_Swipe -= OnTouchSwipe;
    }



    /// <summary>
    /// 在OnDestroy中删除注册事件
    /// </summary>
    private void OnDestroy()
    {
        //删除委托
        EasyTouch.On_TouchStart -= OnTouchStart;
        EasyTouch.On_TouchUp -= OnTouchEnd;
        EasyTouch.On_Swipe -= OnTouchSwipe;
    }



    /// <summary>
    /// 开始手势
    /// </summary>
    /// <param name="gesture"></param>
    void OnTouchStart(Gesture gesture)
    {
        print("OnTouchStart");
        print(gesture.startPosition + "开始坐标");
    }



    /// <summary>
    /// 结束手势
    /// </summary>
    /// <param name="gesture"></param>
    void OnTouchEnd(Gesture gesture)
    {
        print("OnTouchEnd");
        print(gesture.position + "结束坐标");
        print(gesture.actionTime + "结束持续了多久");
    }



    /// <summary>
    /// 拖动手势
    /// </summary>
    /// <param name="gesture"></param>
    void OnTouchSwipe(Gesture gesture)
    {
        print("OnTouchSwipe");
        print(gesture.position + "拖动坐标");
        print(gesture.actionTime + "拖动持续了多久");
        print(gesture.swipe + "类型");
    }
}

