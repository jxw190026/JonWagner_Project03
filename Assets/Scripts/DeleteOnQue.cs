﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnQue : MonoBehaviour
{
    // Start is called before the first frame update
    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
