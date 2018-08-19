using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 重力の中心点を変えるためのクラス。適当なオブジェクトに追加して使う。
/// </summary>
public class GravityController : MonoBehaviour
{
    /// <summary>重力加速度</summary>
    [SerializeField] float m_gravitionalAccelaration = 9.81f;

    /// <summary>重力の中心点</summary>
    [SerializeField] Transform m_centerOfGravity;

    /// <summary>プレイヤーの Transform</summary>
    Transform m_player;

    void Start()
    {
        // プレイヤーの位置情報を得るために Transform を取っておく
        m_player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // 重力の方向を決める
        Vector3 dir = m_centerOfGravity.position - m_player.position;
        // 重力を設定する
        Physics.gravity = dir.normalized * m_gravitionalAccelaration;
        // 上方向を設定する
        m_player.up = -1 * dir;
    }
}
