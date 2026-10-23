using UnityEngine;

// 화면이 멈추는지 보기 위한 "살아 있음" 표시. 큐브에 붙인다
public class Spinner : MonoBehaviour
{
    public float degreesPerSecond = 90f;

    void Update()
    {
        transform.Rotate(0f, degreesPerSecond * Time.deltaTime, 0f);
    }
}