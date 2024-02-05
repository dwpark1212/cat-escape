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
        //버튼을 클릭하면 람다문이 호출됨
        this.btnLoadScene.onClick.AddListener(() =>
        {
            Debug.Log("villegeScene으로 전환");
            SceneManager.LoadScene("VillegeScene");
        });
    }
    private void CreateHero()
    {
        GameObject heroGo = Instantiate(this.HeroPrefab);
        Debug.LogFormat("heroGo : {0}", heroGo);
    }
}
