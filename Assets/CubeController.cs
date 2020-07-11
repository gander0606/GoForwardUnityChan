using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour
{

    // キューブの移動速度
    private float speed = -12;

    // 消滅位置
    private float deadLine = -10;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    //CubeがColliderに衝突した時に呼ばれる関数
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //AudioSouceのコンポーネントを取得する
        AudioSource audio = this.gameObject.GetComponent<AudioSource>();
        //ground か　Cube　に衝突した場合
        if (collision.gameObject.tag== "groundTag" || collision.gameObject.tag == "CubeTag")
        {           
            //blockを鳴らす
            audio.Play();           
        }                
    }

}