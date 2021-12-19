using UnityEngine;

/// <summary>
/// 音效系統
/// 提供播放音效的功能
/// </summary>
public class AudioSystem : MonoBehaviour
{
    private AudioSource aud;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip sound)
    {
        aud.PlayOneShot(sound);
    }

    public void PlaySoundWithRandomVolume(AudioClip sound)
    {
        float r = Random.Range(0.8f, 1.2f);
        aud.PlayOneShot(sound, r);
    }
}
