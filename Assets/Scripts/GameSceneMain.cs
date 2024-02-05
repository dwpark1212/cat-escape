using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSceneMain : MonoBehaviour
{

    [SerializeField] private Button btnLoadScene;
    [SerializeField] private GameObject HeroPrefab;

    // Update is called once per frame
    void Update()
    {
        //��ư�� Ŭ���ϸ� ���ٹ��� ȣ���
        this.btnLoadScene.onClick.AddListener(() =>
        {
            Debug.Log("villegeScene���� ��ȯ");
            SceneManager.LoadScene("VillegeScene");
        });
    }
    private void CreateHero()
    {
        GameObject heroGo = Instantiate(this.HeroPrefab);
        Debug.LogFormat("heroGo : {0}", heroGo);
    }
}
