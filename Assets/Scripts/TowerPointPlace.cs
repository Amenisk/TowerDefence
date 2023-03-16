using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPointPlace : MonoBehaviour
{
    [SerializeField] public static Transform _point;

    public void Click(GameObject button)
    {
        _point = button.transform;
    }
}
