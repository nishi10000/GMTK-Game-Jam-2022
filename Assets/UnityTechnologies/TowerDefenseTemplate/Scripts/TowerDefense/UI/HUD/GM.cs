using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using TMPro;

public class GM : MonoBehaviour
{
    //�\��������摜�I�u�W�F�N�g��Raw�摜�R���|�[�l���g
    public RawImage img1;
    public RawImage img2;
    public RawImage img3;
    public TextMeshProUGUI text;
    public TowerDefense.UI.HUD.BuildSidebar buildSideBar;
    private float countup = 3.0f;
    private bool pushFlg = false;

    //�\��������摜���X�g
    public List<Texture> texture_list = new List<Texture>();

    // Start is called before the first frame update
    void Start()
    {
        img1 = GameObject.Find("Dice1").GetComponent<RawImage>();
        img2 = GameObject.Find("Dice2").GetComponent<RawImage>();
        img3 = GameObject.Find("Dice3").GetComponent<RawImage>();
        //1�`10�̉摜��ǂݍ���
        read_img(6);

        text = GameObject.Find("DiceTotalText").GetComponent<TextMeshProUGUI>();

    }

    void Update()
    {
        //���Ԃ��J�E���g����
        countup += Time.deltaTime;
        if (countup <= 3.0f)
        {
            ChangeImage1();
            ChangeImage2();
            ChangeImage3();
        }
        else
        {
            ChageImageAll();
        }
    }

    //���\�[�X����\�����������摜���w�肵���������ǂݍ��ފ֐�
    public void read_img(int n)
    {
        Texture tmp;
        for (int i = 0; i < n+1; i++)
        {
            tmp = Resources.Load("img/" + i) as Texture;
            texture_list.Add(tmp);
        }
    }

    //�{�^���������ꂽ���̊֐�
    public void PudhButton()
    {
        pushFlg = true;
        countup = 0.0f;

        text.text = "";
    }

    //3�̃_�C�X��U��֐�
    public void ChageImageAll() 
    {
        int total = 0;
        if(pushFlg == false)
        {
            return;
        }

        pushFlg = false;
        total += ChangeImage1();
        total += ChangeImage2();
        total += ChangeImage3();

        text.text = total.ToString();

        buildSideBar.AddCurrency(total);
    }

    //�{�^���ŌĂяo�����֐�
    public int ChangeImage1()
    {
        //�P�`�\������摜�̐��������_���ŎZ�o
        int random = Random.Range(1, texture_list.Count);

        Debug.Log("�_�C�X�P�̃����_���l��" + random);

        img1.texture = texture_list[random];

        return random;
    }
    //�{�^���ŌĂяo�����֐�
    public int ChangeImage2()
    {
        //�P�`�\������摜�̐��������_���ŎZ�o
        int random = Random.Range(1, texture_list.Count);

        Debug.Log("�_�C�X�Q�̃����_���l��" + random);

        img2.texture = texture_list[random];

        return random;
    }
    //�{�^���ŌĂяo�����֐�
    public int ChangeImage3()
    {
        //�P�`�\������摜�̐��������_���ŎZ�o
        int random = Random.Range(1, texture_list.Count);

        Debug.Log("�_�C�X�R�̃����_���l��" + random);

        img3.texture = texture_list[random];

        return random;
    }
}
