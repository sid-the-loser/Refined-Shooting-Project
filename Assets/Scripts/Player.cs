using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
    [Flags] public enum ColoursPlayer
    {
        Red=001,
        Green=010,
        Blue=100
    }

    [SerializeField]private ColoursPlayer currentColor;
    
    private readonly Color _red = Color.red;
    private readonly Color _green = Color.green;
    private readonly Color _blue = Color.blue;
    
    private readonly Color _redgreen = Color.yellow;
    private readonly Color _redblue = Color.cyan;
    private readonly Color _greenblue = Color.black;
    
    private readonly Color _white = Color.white;

    private Material _playerMat;
    
    // Start is called before the first frame update
    void Start()
    {
        _playerMat = GetComponent<Renderer>().material;
        InputManager.GameMode();
        InputManager.Init(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentColor == ColoursPlayer.Red)
        {
            _playerMat.color = _red;
        }
        else if (currentColor == ColoursPlayer.Green)
        {
            _playerMat.color = _green;
        }
        else if (currentColor == ColoursPlayer.Blue)
        {
            _playerMat.color = _blue;
        }
        else if ((int)currentColor == ((int)ColoursPlayer.Red | (int)ColoursPlayer.Green))
        {
            _playerMat.color = _redgreen;
        }
        else if ((int)currentColor == ((int)ColoursPlayer.Blue | (int)ColoursPlayer.Green))
        {
            _playerMat.color = _greenblue;
        }
        else if ((int)currentColor == ((int)ColoursPlayer.Red | (int)ColoursPlayer.Blue))
        {
            _playerMat.color = _redblue;
        }
        else //if ((int)currentColor == -1) // -1 is the int value if all the flags are selected
        {
            _playerMat.color = _white;
        }
    }

    public void SetColor(ColoursPlayer colour)
    {
        currentColor = colour;
    }
}
