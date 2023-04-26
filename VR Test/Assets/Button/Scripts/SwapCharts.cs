using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapCharts : MonoBehaviour
{
    public GameObject chart1;
    public GameObject chart2;
    public GameObject metricCalculator;

    private void Update() {
         if (Input.GetKeyDown(KeyCode.C))
        {
            if(metricCalculator.GetComponent<MetricCalc>().isActiveAndEnabled){
                chart1.SetActive(false);
                chart2.SetActive(true);
                metricCalculator.GetComponent<MetricCalc>().enabled = false;
                metricCalculator.GetComponent<MetricCalc2>().enabled = true;
            }else{
                chart1.SetActive(true);
                chart2.SetActive(false);
                metricCalculator.GetComponent<MetricCalc>().enabled = true;
                metricCalculator.GetComponent<MetricCalc2>().enabled = false;
            }
                
        }
    }

}
