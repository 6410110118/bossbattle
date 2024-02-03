using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBehavior : StateMachineBehaviour {

    private Boss boss;
	private Player player;

	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        boss = animator.GetComponent<Boss>();
        boss.isDead = true;
		player = animator.GetComponent<Player>();
        if (player != null)
        {
            player.isDead = false; // กำหนดค่า isDead ให้ถูกต้อง
        }

    }

	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
       
    }

	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	
	}


}
