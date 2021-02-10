using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JIR_RightControlController : MonoBehaviour
{
    //1. 버튼 충돌 여부에 따라서 컨트롤러의 콜라이더 컴포넌트를 껐다 켰다 하고싶다
    public SphereCollider ir_l_cc;
    JIR_TraningConveyorManager ir_T_cm;

    private void Awake()
    {
        ir_T_cm = GameObject.Find("ConveyorManager").GetComponent<JIR_TraningConveyorManager>();
    }

    private void Update()
    {
        if (ir_T_cm.isStopMoving == true)
        {
            gameObject.GetComponent<SphereCollider>().radius = 0.1f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "StartBtn")
        {
            gameObject.GetComponent<SphereCollider>().radius = 0.8f;
            ir_l_cc.GetComponent<SphereCollider>().radius = 0.8f;
        }
    }
    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.gameObject.name.Contains("Item"))
    //    {
    //        ir_l_cc.GetComponent<SphereCollider>().radius = 0.1f;
    //    }
    //}
    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.name.Contains("Item"))
    //    {
    //        ir_l_cc.GetComponent<SphereCollider>().radius = 0.8f;
    //    }
    //}
}
