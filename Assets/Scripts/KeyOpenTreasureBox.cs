using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyOpenTreasureBox : MonoBehaviour
{
    private Animator _animator;

    //private bool _haveKey = false;
    // Start is called before the first frame update
    void Start()
    {
        _animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("key"))
        {
            _animator.SetBool("haveKey", true);
        }
    }
}
