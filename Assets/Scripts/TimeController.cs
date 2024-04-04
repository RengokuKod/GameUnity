using UnityEngine;
using TMPro; // ��� TMPro, ���� �� ����������� TextMeshPro

public class TimeDisplay : MonoBehaviour
{
    public TextMeshProUGUI timeText; // ��� public TextMeshProUGUI timeText;

    void Update()
    {
        timeText.text = "Time: " + Time.time.ToString("0.00");
    }
}