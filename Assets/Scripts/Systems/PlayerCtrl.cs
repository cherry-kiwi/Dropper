using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerCtrl : MonoBehaviour
{
    public GameObject cam;
    public GameObject goal;
    public GameObject GameOver;
    public Main_Camera camCtrl;

    Rigidbody rigid;
    public float HP = 100.0f;
    public float score = 0.0f;

    public float turnSpeed = 4.0f; // ���콺 ȸ�� �ӵ�
    public float speed = 2.0f; // �̵� �ӵ�

    public bool over = false;

    public TMP_Text text;

    private float xRotate = 0.0f; // ���� ����� X�� ȸ������ ���� ���� ( ī�޶� �� �Ʒ� ���� )

    void Start()
    {
        camCtrl = cam.GetComponent<Main_Camera>();
        rigid = GetComponent<Rigidbody>();
        text.text = score.ToString();
    }

    void Update()
    {
        if (!over)
        {
            MouseRotation();
        }
        else
        {
            camCtrl.enabled = false;
            cam.transform.position = new Vector3(0, 15, 0);
            cam.transform.rotation = Quaternion.Euler(90, 0, 0);
        }
    }

    void FixedUpdate()
    {
        if (!over)
        {
            KeyboardMove();
        }
    }

    // ���콺�� �����ӿ� ���� ī�޶� ȸ�� ��Ų��.
    void MouseRotation()
    {
        // �¿�� ������ ���콺�� �̵��� * �ӵ��� ���� ī�޶� �¿�� ȸ���� �� ���
        float yRotateSize = Input.GetAxis("Mouse X") * turnSpeed;
        // ���� y�� ȸ������ ���� ���ο� ȸ������ ���
        float yRotate = transform.eulerAngles.y + yRotateSize;

        // ���Ʒ��� ������ ���콺�� �̵��� * �ӵ��� ���� ī�޶� ȸ���� �� ���(�ϴ�, �ٴ��� �ٶ󺸴� ����)
        float xRotateSize = -Input.GetAxis("Mouse Y") * turnSpeed;
        // ���Ʒ� ȸ������ ���������� -45�� ~ 80���� ���� (-45:�ϴù���, 80:�ٴڹ���)
        // Clamp �� ���� ������ �����ϴ� �Լ�
        xRotate = Mathf.Clamp(xRotate + xRotateSize, -45, 80);

        // ī�޶� ȸ������ ī�޶� �ݿ�(X, Y�ุ ȸ��)
        transform.eulerAngles = new Vector3(xRotate, yRotate, 0);
    }

    // Ű������ ������ ���� �̵�
    void KeyboardMove()
    {
        // WASD Ű �Ǵ� ȭ��ǥŰ�� �̵����� ����
        Vector3 dir = new Vector3(
            Input.GetAxis("Horizontal"),
            0,
            Input.GetAxis("Vertical")
        );
        // �̵����� * �ӵ� * �����Ӵ��� �ð��� ���ؼ� ī�޶��� Ʈ�������� �̵�
        transform.Translate(dir * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor" && !over)
        {
            over = true;
            GameOver.SetActive(true);

        }

        if (collision.gameObject.tag == "Goal")
        {
            over = true;
            goal.gameObject.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Item_ScoreDOWN")
        {
            Destroy(other.gameObject);
            score += 150;
            text.text = score.ToString();
        }

        if (other.gameObject.tag == "Item_ScoreUP")
        {
            Destroy(other.gameObject);
            score -= 150;
            text.text = score.ToString();
        }
    }
}