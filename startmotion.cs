using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startmotion : MonoBehaviour {

    Animator _animator;

    // Use this for initialization
    void Start () {
        _animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if(MMD_VmdCameraLoad.animflg)
        {
            _animator.SetBool("startflg", true);
        }
    }
}
