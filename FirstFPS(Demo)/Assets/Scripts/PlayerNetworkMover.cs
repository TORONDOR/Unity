using UnityEngine;
using System.Collections;

public class PlayerNetworkMover : Photon.MonoBehaviour {
	
//	public delegate void Respawn(float time);
//	public event Respawn RespawnMe;
//	
//	Vector3 position;
//	Quaternion rotation;
//	float smoothing = 10f;
//	float health = 100f;
	
	
	void Start () {
		
		if(photonView.isMine)
		{
			GetComponent<Rigidbody>().useGravity = true;
			//GetComponent<FirstPersonCharacter>().enabled = true;
			//GetComponent<FirstPersonHeadBob>().enabled = true;
			//GetComponent<SimpleMouseRotator>().enabled = true;
			//GetComponentInChildren<PlayerShooting>().enabled = true;
			//foreach(SimpleMouseRotator rot in GetComponentsInChildren<SimpleMouseRotator>())
			//	rot.enabled = true;
			GetComponent<FPSInput>().enabled = true;
			GetComponent<MouseLook>().enabled = true;
			GetComponentInChildren<MouseLookCamera>().enabled = true;
			GetComponent<PlayerCharacter>().enabled = true;
			GetComponentInChildren<RayShooter>().enabled = true;
			//GetComponentInChildren<MouseLook>().enabled = true;
			foreach(Camera cam in GetComponentsInChildren<Camera>())
				cam.enabled = true;
			
			transform.Find("Camera").gameObject.layer = 0;
		}
//		else{
//			StartCoroutine("UpdateData");
//		}
	}
//	
//	IEnumerator UpdateData()
//	{
//		while(true)
//		{
//			transform.position = Vector3.Lerp(transform.position, position, Time.deltaTime * smoothing);
//			transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * smoothing);
//			yield return null;
//		}
//	}
//	
//	void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
//	{
//		if(stream.isWriting)
//		{
//			stream.SendNext(transform.position);
//			stream.SendNext(transform.rotation);
//			stream.SendNext(health);
//		}
//		else
//		{
//			position = (Vector3)stream.ReceiveNext();
//			rotation = (Quaternion)stream.ReceiveNext();
//			health = (float)stream.ReceiveNext();
//		}
//	}
//	
//	[PunRPC]
//	public void GetShot(float damage)
//	{
//		health -= damage;
//		if(health <= 0 && photonView.isMine)
//		{
//			if(RespawnMe != null)
//				RespawnMe(3f);
//			
//			PhotonNetwork.Destroy (gameObject);
//		}
//	}
	
}