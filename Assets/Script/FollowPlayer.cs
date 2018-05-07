
using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour
{
	public Transform target;    // ターゲットへの参照
	private Vector3 offset;  // 相対座標

	void Start () {
		// 自分自身と target との相対鏡を求める
		offset = transform.position - target.position;
	}

	void Update ()
	{
		// 自分の座標にtargetの座標を代入する     		
		// NOTE: チュートリアルでは getComponent().position だったが、それでは動かないので↓のように(transformとは何だろうか)
		transform.position = target.position + offset;
	}
}