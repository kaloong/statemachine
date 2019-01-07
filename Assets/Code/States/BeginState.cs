using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class BeginState : IStateBase {

		private StateManager manager;

		public BeginState( StateManager managerRef ) {
			manager = managerRef;
			Debug.Log("Constructing BeginState");
			Time.timeScale = 0;
		}
		public void StateUpdate(){
			if (Input.GetKeyUp (KeyCode.Space)) {
				manager.SwitchState(new PlayState(manager));
			} 
		}
		public void ShowIt(){
			if (GUI.Button (new Rect (10, 10, 150, 100), "Press to Play")) {
				Time.timeScale=1;
				manager.SwitchState (new PlayState (manager));
			}
		}
	}
}