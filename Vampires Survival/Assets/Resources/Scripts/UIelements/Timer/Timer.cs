using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private int seconds = 0;
    private int minutes = 0;
    [SerializeField] private int delta = 0;
    
    [SerializeField] private Text _timerText;
    [SerializeField] private Text _timerTextForLosePanel;
    private void Start()
    {
        StartCoroutine(TimerMechanims());
    }
    private IEnumerator TimerMechanims()
    {
        while(true)
        {
            if(seconds == 59)
            {
                minutes++;
                seconds = -1;
            }
            seconds += delta;
            _timerText.text = minutes.ToString("D2") + " : " + seconds.ToString("D2");
            _timerTextForLosePanel.text = "Time: " + minutes.ToString("D2") + " : " + seconds.ToString("D2");
            yield return new WaitForSeconds(1);
        }
    }
}
