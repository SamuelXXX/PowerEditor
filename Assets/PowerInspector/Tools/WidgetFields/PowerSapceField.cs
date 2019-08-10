﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PowerInspector
{
    [System.Serializable]
    public class PowerSpaceField : PowerWidget
    {
        public float height { get; private set; }

        public PowerSpaceField(float height)
        {
            this.height = height;
        }
    }
}



