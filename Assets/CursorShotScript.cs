using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class CursorShotScript : MonoBehaviour
{
	//�@�J�[�\���Ɏg�p����e�N�X�`��
	[SerializeField]
	private Texture2D cursor;
	public static int score = 0;
	public Text scoreText; //Text�p�ϐ�

	void Start()
	{
		//�@�J�[�\�������O�̃J�[�\���ɕύX
		Cursor.SetCursor(cursor, new Vector2(cursor.width / 2, cursor.height / 2), CursorMode.ForceSoftware);
	}
	void Update()
	{
		//�@�}�E�X�̍��N���b�N�Ō���
		if (Input.GetMouseButton(0))
		{
			Shot();
		}
	}

	//�@�G������
	void Shot()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		int layer = LayerMask.NameToLayer("Enemy");
		int layer_mask = 1 << layer;
		if (Physics.Raycast(ray, out hit, 100f, layer_mask))
		{
			GetComponent<AudioSource>().Play();
			if (EventSystem.current.IsPointerOverGameObject())
			{
				// ���Ԃ����Ă�̂ŏ����L�����Z���i�}�E�X�Nver�j
				return;
			}
			if (hit.collider.gameObject.tag == "judo")
			{
				score += 1200;
				
			}
			if (hit.collider.gameObject.tag == "resuring")
			{
				score += 700;
				
			}
			if (hit.collider.gameObject.tag == "sukebo")
			{
				score += 500;
				
			}
			if (hit.collider.gameObject.tag == "taisou")
			{
				score += 500;
				
			}
			if (hit.collider.gameObject.tag == "takkyu")
			{
				score += 400;
				
			}
			scoreText.text = string.Format("Score:{0}", score);
			Destroy(hit.collider.gameObject);
		}
		
	}

public static int getscore()
			{
				return score;
			}

}