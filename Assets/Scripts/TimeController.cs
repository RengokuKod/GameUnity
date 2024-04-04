using UnityEngine;
using TMPro; // Или TMPro, если вы используете TextMeshPro

public class TimeDisplay : MonoBehaviour
{
    public TextMeshProUGUI timeText; // Или public TextMeshProUGUI timeText;

    void Update()
    {
        timeText.text = "Time: " + Time.time.ToString("0.00");
    }
}