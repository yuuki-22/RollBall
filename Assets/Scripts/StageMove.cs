// ライブラリの宣言 -> これからこの機能を使うよ
using UnityEngine;
using UnityEngine.InputSystem;

public class StageMove : MonoBehaviour
{
    // 変数・関数
    // 変数 -> int,string値を格納するための箱
    // データ型(int,string,InputAction) + 変数名(num,name)
    private InputAction moveInput;

    // 関数 -> 処理をまとめて実行するための箱

    // 目的(抽象的課題)：ステージを回転させること
    // 手段(具体的課題)：ActionMapを使用してプレイヤーの入力を受け取る
    // 受け取った入力をもとにステージのRotationを変更する
    // 
    // 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveInput = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(moveInput.ReadValue<Vector2>());

        // A + B -> A = A + B
        // this.transform.localPothion -> このコードがアタッチされているオブジェクトの位置情報
        // moveInput.ReadValue<Vector2> ->(X,Y,Z=0)

        Vector3 rotation;
        float threshold = 0.2f;

        // moveInput.ReadValue<Vector2>.x => X軸
        // moveInput.ReadValue<Vector2>.y => Y軸
        rotation = new Vector3(moveInput.ReadValue<Vector2>().y*threshold, 0, moveInput.ReadValue<Vector2>().x)* threshold;
        this.transform.Rotate(rotation);
    
    }
}
