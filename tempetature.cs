using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemperatureUI : MonoBehaviour
{
    public Temperature playerTemperature;
    public TextMeshProUGUI temperatureText;

    public void UpdateTemperatureText()
    {
        float roundedTemperature = Mathf.Round(playerTemperature.CurrentTemperature * 10.0f) * 0.1f;
        temperatureText.text = roundedTemperature.ToString();
    }
}
