using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager
{
    private static Controls _controls = new Controls();

    public static void Init(Player p)
    {
        _controls.Ingame.butt1.performed += ctx =>
        {
            p.SetColor(Player.ColoursPlayer.Red);
        };
        _controls.Ingame.butt2.performed += ctx =>
        {
            p.SetColor(Player.ColoursPlayer.Green);
        };
        _controls.Ingame.butt3.performed += ctx =>
        {
            p.SetColor(Player.ColoursPlayer.Blue);
        };
    }
        
    public static void GameMode()
    {
        _controls.Ingame.Enable();
    }
}
