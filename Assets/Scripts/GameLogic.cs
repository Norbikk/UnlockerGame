using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
public class GameLogic : MonoBehaviour
{
    [SerializeField] private Text[] pins;
    [SerializeField] private GameObject winScene;

    private int _firstPinNum;

    private int _secondPinNum;

    private int _thirdPinNum;
    
    private const int MAXRange = 10;
    private const int MINRange = 0;
    private void Start()
   {
       _firstPinNum = Random.Range(0, 10);
       _secondPinNum = Random.Range(0, 10);
       _thirdPinNum = Random.Range(0, 10);
       
       pins[0].text = _firstPinNum.ToString();
       pins[1].text = _secondPinNum.ToString();
       pins[2].text = _thirdPinNum.ToString();
       
   }
    private void Update()
   {
       if (_secondPinNum >= MAXRange)
       {
           _secondPinNum = MAXRange;
           pins[1].text = _secondPinNum.ToString();
       }
       WinGame();
   }
    public void ONClickDrill()
   {
       if (_firstPinNum < MAXRange)
       {
           _firstPinNum += 1;
       }
       if (_secondPinNum > MINRange)
       {
           _secondPinNum -= 1;
       }
       else if (_firstPinNum >= MAXRange && _secondPinNum <= MINRange)
       {
           return;
       }
       else
       {
           _firstPinNum += 1;
           _secondPinNum -= 1;
       }
       pins[0].text = _firstPinNum.ToString();
       pins[1].text = _secondPinNum.ToString();
   }
    public void ONClickHammer()
   {
       if (_firstPinNum > MINRange)
       {
           _firstPinNum -= 1;
       }

       if (_secondPinNum < MAXRange)
       {
           _secondPinNum += 2;
       }

       if (_thirdPinNum > MINRange)
       {
           _thirdPinNum -= 1;
       }

       pins[0].text = _firstPinNum.ToString();
       pins[1].text = _secondPinNum.ToString();
       pins[2].text = _thirdPinNum.ToString();
   }
    public void ONClickLockpick()
   {
       if (_firstPinNum > MINRange)
       {
           _firstPinNum -= 1;
       }
       if (_secondPinNum < MAXRange)
       {
           _secondPinNum += 1; 
       }
       if (_thirdPinNum < MAXRange)
       {
           _thirdPinNum += 1;  
       }
       pins[0].text = _firstPinNum.ToString();
       pins[1].text = _secondPinNum.ToString();
       pins[2].text = _thirdPinNum.ToString();
   }
    private void WinGame()
   {
       if (_firstPinNum == 5 && _secondPinNum == 5 && _thirdPinNum == 5) 
       { 
           winScene.SetActive(true); 
           Time.timeScale = 0;
       }
   }
    public void ResetPins()
   {
       _firstPinNum = Random.Range(1, 10);
       _secondPinNum = Random.Range(1, 10);
       _thirdPinNum = Random.Range(1, 10);
       
       pins[0].text = _firstPinNum.ToString();
       pins[1].text = _secondPinNum.ToString();
       pins[2].text = _thirdPinNum.ToString();
   }
}
