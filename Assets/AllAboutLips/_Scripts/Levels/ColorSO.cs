﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ColorSO", menuName = "AllAboutLip/ColorSO", order = 5)]
public class ColorSO : ScriptableObject
{
    public List<Color> colors = new List<Color>();
}
