using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class PlayState: IStateBase
	{
		private StateManager manager;
		public PlayState (StateManager managerRef)
		{
			manager = managerRef;
			Debug.Log("Constructing PlayState");
		}
		public void StateUpdate(){
			if (Input.GetKeyUp (KeyCode.Space)) {
				manager.SwitchState(new WonState(manager));
				Time.timeScale = 0; 
			}
			if (Input.GetKeyUp (KeyCode.Return)){
				manager.SwitchState(new LostState(manager));
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

