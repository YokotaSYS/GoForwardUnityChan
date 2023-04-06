using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSound : MonoBehaviour
{
    // �T�E���h�Đ��p�̃I�[�f�B�I�\�[�X
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

    // OnCollisionEnter�֐����g�p���āA�L���[�u���n�ʂɏՓ˂����Ƃ��ɃT�E���h���Đ�����
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            // �n�ʂɏՓ˂����Ƃ��ɃT�E���h���Đ�����
            audioSource.Play();
            Debug.Log("jimen");
        }

        if (collision.gameObject.tag == "Cube")
        {
            // �u���b�N���m���Ԃ��������ɃT�E���h���Đ�����
            this.audioSource.Play();
            Debug.Log("block");
        }

    }
}
