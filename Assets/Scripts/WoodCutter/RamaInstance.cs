﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamaInstance : MonoBehaviour {

    public GameObject[] ramas = new GameObject[3];
    TypeRama rand = TypeRama.NONE;

    private enum TypeRama
    {
        NONE,
        RIGHT,
        LEFT
    }

    // Use this for initialization
    void Awake () {
        rand = (TypeRama)Random.Range(0f, 3f);

        ramas[(int)rand].gameObject.SetActive(true);
    }
}
