﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntensityEntity
{
    private string _name;

    public IntensityEntity(string name)
    {
        _name = name;
    }

    public string Name => _name;
}
