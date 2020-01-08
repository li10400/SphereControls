using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControls : MonoBehaviour
{

    public Vector2[] VerticalPostion;
    public int Layer;
    public float Radius;

    public Vector3[] aaa;

    public Dictionary<int, Vector3[]> ItemPostion;
    // Start is called before the first frame update
    void Start()
    {
        LayerPostion();
    }

    //计算出圆弧度坐标
    public void LayerPostion() {
        VerticalPostion = new Vector2[Layer];
        aaa = new Vector3[Layer];
        float angle = 180 / (float)Layer;
        for (int i = 0; i < VerticalPostion.Length; i++) {
            float tempRadian = Angle2Radian(i*angle-90+(angle/2));

            float x = Mathf.Cos(tempRadian) + Radius;
            float y= Mathf.Sin(tempRadian) + Radius;
            VerticalPostion[i] = new Vector2(x, y);
            aaa[i] = new Vector3(x,y);
        }
    }


    public void ComputePostion() {



    }


    //角度转弧度
    private float Angle2Radian(float angle) {

        return (angle * Mathf.PI) / 180;
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        if (aaa.Length == 0) return;

        foreach (Vector3 v in aaa) {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(v, 0.1f);
        }
    }
}
