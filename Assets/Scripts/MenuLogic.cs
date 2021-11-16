using UnityEngine;
public class MenuLogic : MonoBehaviour
{
    [SerializeField] private TimerLogic timerLogic;
    [SerializeField] private GameLogic gameLogic;
    [SerializeField] private GameObject[] menuScreens;
    
    private GameObject _currentScreen;
    private void Start()
    {
        menuScreens[0].SetActive(true);
        _currentScreen = menuScreens[0];
        Time.timeScale = 0;
    }
    public void ChangeState(GameObject state)
    {
        if (_currentScreen != null)
        {
            _currentScreen.SetActive(false);
            state.SetActive(true);
            _currentScreen = state;
        }
    }
    public void OnClickPlay()
    {
        Time.timeScale = 1;
    }
    public void OnClickAgain()
    {
        gameLogic.ResetPins();
        timerLogic.ResetTimer();
        Time.timeScale = 1;
    }
    public void OnClickMainMenu()
    {
        gameLogic.ResetPins();
        timerLogic.ResetTimer();
    }
}
