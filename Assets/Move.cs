using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform childTransform; //움직일 자식 게임 오브젝트의 트랜스폼


    void Start()
    {
        //자신의 전역 위치를 (0,-1,0)으로 변경 . position은 global 순간이동
        transform.position = new Vector3(0,-1,0);


        //자식의 지역 위치를 (0,2,0)으로 변경 . transform은 local 평행이동
        childTransform.localPosition = new Vector3(0,2,0);


        //자신의 전역 회전을 (0,0,30)으로 변경
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30));


        //자식의 지역 회전을 (0,60,0)으로 변경
        childTransform.localRotation = Quaternion.Euler(new Vector3(0, 60, 0));



    }


    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //위쪽 방향키를 누르면 초당 (0,1,0)의 속도로 평행이동
            // transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime);
            // transform.position = transform.position + transform.up * 1 * Time.deltaTime;
            transform.position += transform.up * Time.deltaTime; //지역조표로 연산
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //아래쪽 방향키를 누르면 초당 (0,-1,0)의 속도로 평행이동
            transform.Translate(new Vector3(0, -1 , 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //왼쪽 방향키를 누르면
            //자신을 초당 (0,0,180) 회전
            transform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime);
            //자식을 초당 (0,180,0) 회전
            childTransform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //오른쪽 방향키를 누르면
            //자신을 초당(0,0,-180) 회전
            transform.Rotate(new Vector3(0, 0, -180) * Time.deltaTime);
            //자식을 초당 (0,-180,0) 회전
            childTransform.Rotate(new Vector3(0, -180, 0) * Time.deltaTime);
           
        }

    }
}
