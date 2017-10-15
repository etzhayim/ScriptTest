using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	private int mp = 53;	// MP

	public void Magic () {
		if (mp < 5) {
			// MPが5より小さい時
			Debug.Log ("MPが足りないため魔法が使えない。");
		} else {
			// MPが5以上の時
			mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + mp + "。");
		}
	}
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 配列pointsを初期化する
		int[] points = { 1, 2, 3, 4, 5 };

		// pointsの中身を表示する
		Debug.Log (points[0]);
		Debug.Log (points[1]);
		Debug.Log (points[2]);
		Debug.Log (points[3]);
		Debug.Log (points[4]);

		// pointsの要素数繰り返す
		for (int i = 0; i < points.Length; i++) {
			// points[i]を逆順に表示する
			Debug.Log (points[points.Length - 1 - i]);
		}

		// Bossクラスの変数を宣言してインスタンスを代入
		Boss wiz = new Boss ();

		for (int i = 0; i < 11; i++) {
			// 魔法攻撃の関数を呼び出す
			wiz.Magic ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
