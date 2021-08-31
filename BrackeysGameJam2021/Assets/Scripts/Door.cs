using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    private bool isLocked;
	private Animator anim;

	[SerializeField] private GameObject openDoor;
	[SerializeField] private Text hint;

	void Awake(){
		anim = openDoor.GetComponent<Animator>();
	}

	public void OpenDoor(){
		if(isLocked == false){
			anim.Play("DoorAnim");
			Destroy(this.GetComponent<BoxCollider2D>());
		}
	}

	public void ShowHint(int option){
		if(option == 0){
			hint.gameObject.SetActive(false);
		}
		if(option == 1){
			hint.gameObject.SetActive(true);
		}
	}
}
