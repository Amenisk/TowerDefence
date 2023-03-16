using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class Registration : MonoBehaviour
{
    [SerializeField] private Text _firstNameField;
    [SerializeField] private Text _lastNameField;
    [SerializeField] private Text _emailField;
    [SerializeField] private Text _passwordField;

    private void Update()
    {
        
    }
    public void Registrate()
    {
        PlayerPrefs.SetString("Email", _emailField.text.ToString());
        PlayerPrefs.Save();
        PlayerPrefs.SetString("Password", _passwordField.text.ToString());
        PlayerPrefs.Save();
        _firstNameField.text = "";
        _lastNameField.text = ""; ;
        _emailField.text = "";
        _passwordField.text = "";
    }
}
