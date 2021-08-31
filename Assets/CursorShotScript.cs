using UnityEngine;
using System.Collections;

public class CursorShotScript : MonoBehaviour
{

	//�@�J�[�\���Ɏg�p����e�N�X�`��
	[SerializeField]
	private Texture2D cursor;

	void Start()
	{
		//�@�J�[�\�������O�̃J�[�\���ɕύX
		Cursor.SetCursor(cursor, new Vector2(cursor.width / 2, cursor.height / 2), CursorMode.ForceSoftware);
	}

	void Update()
	{
		//�@�}�E�X�̍��N���b�N�Ō���
		if (Input.GetButtonDown("Fire1"))
		{
			Shot();
		}
	}

	//�@�G������
	void Shot()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;

		if (Physics.Raycast(ray, out hit, 100f, LayerMask.GetMask("Enemy")))
		{
			Destroy(hit.collider.gameObject);
		}
	}
}