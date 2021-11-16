using UnityEngine;
using UnityEngine.UI;
public class TimerLogic : MonoBehaviour
{
    [SerializeField] private Text timerText;
    [SerializeField] private GameObject looserScene;

    private const int MAXTime = 60;
    private float _currentTime = 60f;
    private void Update()
    {
        TimeCalculate();
        LooseLogic();
    }
    private void TimeCalculate()
    {
       _currentTime -=  Time.deltaTime;
        timerText.text = Mathf.Round(_currentTime).ToString();
    }
    private void LooseLogic()
    {
        if (!(_currentTime <= 0)) return;
        looserScene.SetActive(true);
        Time.timeScale = 0;
    }
    public void ResetTimer()
    {
        _currentTime = MAXTime;
        
    }
}
