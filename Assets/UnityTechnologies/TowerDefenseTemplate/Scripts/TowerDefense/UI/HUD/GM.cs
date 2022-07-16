using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using TMPro;

public class GM : MonoBehaviour
{
    //表示させる画像オブジェクトのRaw画像コンポーネント
    public RawImage img1;
    public RawImage img2;
    public RawImage img3;
    public TextMeshProUGUI text;
    public TowerDefense.UI.HUD.BuildSidebar buildSideBar;
    private float countup = 3.0f;
    private bool pushFlg = false;

    //表示させる画像リスト
    public List<Texture> texture_list = new List<Texture>();

    // Start is called before the first frame update
    void Start()
    {
        img1 = GameObject.Find("Dice1").GetComponent<RawImage>();
        img2 = GameObject.Find("Dice2").GetComponent<RawImage>();
        img3 = GameObject.Find("Dice3").GetComponent<RawImage>();
        //1～10の画像を読み込む
        read_img(6);

        text = GameObject.Find("DiceTotalText").GetComponent<TextMeshProUGUI>();

    }

    void Update()
    {
        //時間をカウントする
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

    //リソースから表示させたい画像を指定した個数だけ読み込む関数
    public void read_img(int n)
    {
        Texture tmp;
        for (int i = 0; i < n+1; i++)
        {
            tmp = Resources.Load("img/" + i) as Texture;
            texture_list.Add(tmp);
        }
    }

    //ボタンが押された時の関数
    public void PudhButton()
    {
        pushFlg = true;
        countup = 0.0f;

        text.text = "";
    }

    //3つのダイスを振る関数
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

    //ボタンで呼び出される関数
    public int ChangeImage1()
    {
        //１～表示する画像の数をランダムで算出
        int random = Random.Range(1, texture_list.Count);

        Debug.Log("ダイス１のランダム値は" + random);

        img1.texture = texture_list[random];

        return random;
    }
    //ボタンで呼び出される関数
    public int ChangeImage2()
    {
        //１～表示する画像の数をランダムで算出
        int random = Random.Range(1, texture_list.Count);

        Debug.Log("ダイス２のランダム値は" + random);

        img2.texture = texture_list[random];

        return random;
    }
    //ボタンで呼び出される関数
    public int ChangeImage3()
    {
        //１～表示する画像の数をランダムで算出
        int random = Random.Range(1, texture_list.Count);

        Debug.Log("ダイス３のランダム値は" + random);

        img3.texture = texture_list[random];

        return random;
    }
}
