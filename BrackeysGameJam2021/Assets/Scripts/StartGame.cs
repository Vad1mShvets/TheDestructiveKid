using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
	[SerializeField] private Child childScript;
	[SerializeField] private SpriteRenderer childSpriteRenderer;
	[SerializeField] private GameObject cutscene;
	[SerializeField] private GameObject inventory;
	private float timer;

	void Awake(){
		childScript.enabled = false;
		childSpriteRenderer.enabled = false;
	}

	public void StartPlayingTheGame(){
		childScript.enabled = true;
		childSpriteRenderer.enabled = true;
		cutscene.SetActive(false);
		inventory.SetActive(true);
		this.GetComponent<StartGame>().enabled = false;
	}

	void Update(){
		timer += Time.deltaTime;
		if(Input.anyKey && timer > 22){
			StartPlayingTheGame();
		}
		if(Input.GetKey(KeyCode.P)){
			StartPlayingTheGame();
		}
	}
}