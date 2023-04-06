using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSound : MonoBehaviour
{
    // サウンド再生用のオーディオソース
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // OnCollisionEnter関数を使用して、キューブが地面に衝突したときにサウンドを再生する
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            // 地面に衝突したときにサウンドを再生する
            audioSource.Play();
            Debug.Log("jimen");
        }

        if (collision.gameObject.tag == "Cube")
        {
            // ブロック同士がぶつかった時にサウンドを再生する
            this.audioSource.Play();
            Debug.Log("block");
        }

    }
}
