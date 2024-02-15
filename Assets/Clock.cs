using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{

    public Transform MinHand;
    public Transform HourHand;
    public Transform SecHoand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        System.DateTime currentTime = System.DateTime.Now;

        //for Debug
        // Debug.Log("Current Time: " + currentTime.ToString());

        // Calculate rotation angles for each hand
        float hoursAngle = (currentTime.Hour % 12) * 30f + currentTime.Minute * 0.5f;
        float minutesAngle = currentTime.Minute * 6f;
        float secondsAngle = currentTime.Second * 6f;

        // Apply rotation to each hand
        HourHand.rotation = Quaternion.Euler(0f, 0f, -hoursAngle +94f);
        MinHand.rotation = Quaternion.Euler(0f, 0f, -minutesAngle +94f);
        SecHoand.rotation = Quaternion.Euler(0f, 0f, -secondsAngle +94f);
    }
}
