using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Audio;            // 引用 音效 命名空間
using UnityEngine.SceneManagement;  // 引用 場景管理 命名空間

/// <summary>
/// 開始畫面選單管理器
/// 開始遊戲、設定、離開遊戲
/// </summary>
public class MenuManager : MonoBehaviour
{
    // unity 按鈕與程式溝通
    // 1. 公開的方法
    // 2. 按鈕設定點及件 on Click

    public AudioMixer mixer;
    
    /// <summary>
    /// 開始遊戲
    /// </summary>
    public void GameStart(float delay)
    {
        // 使用繼承類別的成員語法:
        // 繼承類別的方法
        // 方法名稱(對應的引數)
        // 延遲 delay秒 後呼叫 方法
        Invoke("DelayStartGame", delay);
    }

    private void DelayStartGame()
    {
        // 場景管理.載入場景(場景名稱)
        SceneManager.LoadScene(1);
        // SceneManager.LoadScene(遊戲場景)
    }

    /// <summary>
    /// 遊戲設定
    /// </summary>
    public void GameSettingBGM(float volume)
    {
        mixer.SetFloat("BGM音量", volume);
    }

    /// <summary>
    /// 設定遊戲
    /// </summary>
    public void SettingGameSFX(float volume)
    {
        mixer.SetFloat("SFX音量", volume);
    }

    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void GameQuit(float delay)
    {
        Invoke("DelayQuitGame", delay);       
    }

    private void DelayGameQuit()
    {
        // 應用程式.離開():
        // Quit 不會在 Editor 執行，發布執行檔 手機、PC
        Application.Quit();

        print("離開遊戲~");
    }
}
