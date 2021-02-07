using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class DollyCameraManager : MonoBehaviour
{    //public の　GamaMainManagerを宣言
    public GameMainManager GameMainManager;　　　　　　　　　　　　　　　　　//Cinemachineを使うときは　using の後に　Cinemachine を付ける
    public CinemachineDollyCart CinemachineDollyCart;// public の　Cinemachineを宣言
    public CinemachineSmoothPath[] playerSmoothPaths = new CinemachineSmoothPath[3];
    public float CameraSpeed = 10f;//カメラスピードは１０

    public bool IsMoving = false;
    public bool IsMoveEnd = false;

    private Vector3 currentCameraLocalEulerAngles;


    private void Awake()
    {
        currentCameraLocalEulerAngles = CinemachineVirtualCamera.transform.localEulerAngles;
    }

    public void StartCameraAction(int characterPos)
    {
        IsMoving = true;
        IsMoveEnd = false;
        CinemachineDollyCart.m_Speed = CameraSpeed;
        CinemachineDollyCart.m_Path = playerSmoothPaths[characterPos];
    }
    public void EndCameraAction()
    {
        if (CinemachineVirtualCamera.transform.localEulerAngles != currentCameraLocalEulerAngles)
        {
            CinemachineVirtualCamera.transform.localEulerAngles = currentCameraLocalEulerAngles;




        }
    }
}
