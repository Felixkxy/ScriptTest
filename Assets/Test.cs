using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Bossクラスを定義
public class Boss
{
    private int hp = 100;　
    private int power = 25;
    private int mp = 53;
    
    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }
    
    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    //魔法攻撃用の関数
    public void Magic(int skillmp)
    {
        //MPが足りるかを判断する：Trueの場合は1、Falseは0
        int enoughmp = (mp >= skillmp) ? 1 : 0;
        //MPが足りる場合の処理
        if(enoughmp == 1)
        {
            this.mp -= skillmp;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
        else if(enoughmp == 0)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        else
        {
            Debug.Log("予想外のエラーです。");
        }   
    }
}

public class Test : MonoBehaviour {

	void Start ()
    {
        //Arrayを初期化する
        int[] Array = { 1, 2, 3, 4, 5 };

        //順番で並ぶ
        for(int i = 0; i < Array.Length; i++)
        {
            Debug.Log(Array[i]);
        }

        //逆順で並ぶ
        for(int j = Array.Length - 1; j >= 0; j--)
        {
            Debug.Log(Array[j]);
        }

        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //攻撃用の関数を呼び出す
        lastboss.Attack();
        //防御用の関数を呼び出す、ダメージは3
        lastboss.Defence(3);
        //魔法攻撃用の関数を呼び出す、スキルmpは5
        lastboss.Magic(5);
        
        //さらに10回同じ魔法攻撃をする；
        for(int k = 0; k < 10; k++)
        {
            lastboss.Magic(5);
        }
    }

	void Update () {
		
	}
}
