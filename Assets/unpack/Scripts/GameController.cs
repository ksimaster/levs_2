using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("Audio")]
    public AudioSource monsterSound;
    public AudioSource voiceMonsterSound;
    public AudioSource backgoundSound;
    public AudioSource playerSound;
    
    [Header("UI")]
    public GameObject pauseMenuUI;

    [Header("GameObject")]
    public GameObject player;

    private bool isPaused = false;

    private void Start()
    {

        PauseOn();
        
    }
    public void Restart()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void PauseOn()
    {
        pauseMenuUI.SetActive(true);
        isPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0;
    }
    public void PauseOff()
    {
        pauseMenuUI.SetActive(false);
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;

    }
    public void SoundOn()
    {
        monsterSound.mute = false;
        voiceMonsterSound.mute = false;
        backgoundSound.mute = false;
        playerSound.volume = 1;
    }
    public void SoundOff()
    {
        monsterSound.mute = true;
        voiceMonsterSound.mute = true;
        backgoundSound.mute = true;
        playerSound.volume = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                PauseOff();
            }
            else
            {
                PauseOn();
            }  
        }
    }

}
