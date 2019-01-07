using UnityEngine;
using Assets.Code.Interfaces;
namespace Assets.Code.States
{
	public class WonState : IStateBase
	{
		private StateManager manager;
		public WonState (StateManager managerRef )
		{
			manager = managerRef;
			Debug.Log ("Constructing WonState");
		}
		public void StateUpdate(){
			if (Input.GetKeyUp (KeyCode.Space)) {
				manager.SwitchState(new BeginState(manager));
			}
		}
		public void ShowIt(){
			
		}	
	}
}

