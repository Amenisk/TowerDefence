using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Authorization : MonoBehaviour
{
    [SerializeField] private Text _emailField;
    [SerializeField] private Text _passwordField;
    // Start is called before the first frame update
    public void Authorizate()
    {
        var email = PlayerPrefs.GetString("Email");
        var password = PlayerPrefs.GetString("Password");
        if (_emailField.text ==  email
            && _passwordField.text == password)
        {
            SceneManager.LoadScene("Game");
        }
    }
}
