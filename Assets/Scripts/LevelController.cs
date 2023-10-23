using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    [field: SerializeField] public List<Diamond> Diamonds { get; private set; }
    [field: SerializeField] public List<Door> Doors { get; private set; }

    [SerializeField] private WinPanel _winPanel;
    [SerializeField] private Timer _timer;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            ResetLevel();
    }

    public void Win()
    {
        if (CheckDoors())
        {
            AudioManager.Instance.PlayMusic(MusicType.Result, AudioManager.Instance.GetTimeAudioSource());
            Time.timeScale = 0f;
            _winPanel.ShowPanel(_timer.GetTimerText(_timer.ElapsedTime),
            GetDiamondsText(Diamonds, ElementType.Fire), GetDiamondsText(Diamonds, ElementType.Water));
        }
    }

    public void ResetLevel()
    {
         Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private bool CheckDoors()
    {
        var result = Doors.Where(x => x.IsOpen).Count() == 2;
        return result;
    }

    private string GetDiamondsText(List<Diamond> diamonds, ElementType elementType)
    {
        var countAll = diamonds.Where(x => x.ElementType == elementType).ToList();
        var collected = countAll.Where(x => x.Collected).Count();

        return $"{collected}/{countAll.Count()}";
    }
}