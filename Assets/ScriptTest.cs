using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int[] array = new int[5];

        
        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        for (int i = 0; i < 5; i++) {
            Debug.Log(array[i]);
        }
        for (int i= 4; i >= 0; i--) {
            Debug.Log(array[i]);
        }
        Boss lastboss = new Boss();
        for (int i = 0; i < 11; i++)
        { lastboss.Magic(5); }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53;

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }
    //Magic関数内でmpを5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示してください。mpが足りない場合、「MPが足りないため魔法が使えない。」と表示してください
    public void Magic(int usemp)
    { if (mp >= 5){
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは "+mp);
        }
        else { 
        Debug.Log( "MPが足りないため魔法が使えない。");
    }

    }

}
