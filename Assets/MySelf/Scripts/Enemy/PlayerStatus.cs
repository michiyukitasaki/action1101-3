using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//以下はセーブデータクラスの例。

//セーブデータクラスには、このアトリビューションが必須。
[System.Serializable]
public class PlayerStatus
{

    //当然だが外部から扱う値はpublicに。
    public int attackLevel = 1;
    public int attack = 10;

    //計算のみに使う値はprivateのままでOk。
    int attackToAdd = 5;


    //staticの定数を含めてもエラーは出ない。(但しセーブデータ内にファイル名を設置するのが設計上良いかは知らないが)。
    public static string FileName = "SaveData_PlayerStatus";


    public int points = 1000;



    //列挙型も大丈夫。
    public enum ColorType
    {
        Red = 0,
        Blue = 1,
    }

    public enum StatusType
    {
        Attack = 0,
        AttackSpeed = 1,
        Size = 2,
    }


    //Unity独自の型を使用するとエラーが出る。
    /*
        Vector2 size = new Vector2(5, 1);
        Vector3 position = new Vector3(0, 0, 0);
    */


    //引数や、返り値のあるメソッドも使用可能。勿論、外部から扱うのであればpublicに。
    //public int CheckValue(ColorType colorType, StatusType statusType)
    //{

    //    //割愛

    //}

    //通常と同じで、計算でprivateな変数を使用してもOk。
    public void AddAttack()
    {

        attackLevel++;
        attack += attackToAdd;

    }
}