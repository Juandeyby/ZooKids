using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartController : StartApp
{
    private IEnumerator _coroutineStartGame;
    private bool _flatButton;

    public void StartGame()
    {
        _flatButton = true;
        if (_flatButton)
        {
            _coroutineStartGame = StartSongButton();
            StartCoroutine(_coroutineStartGame);
        }
    }

    IEnumerator StartSongButton()
    {
        _flatButton = false;
        AudioSource.PlayClipAtPoint(app.startView.audio, Camera.main.transform.position);
        yield return new WaitForSeconds(app.startView.audio.length);
        SceneManager.LoadScene("MainScene");
    }
}
