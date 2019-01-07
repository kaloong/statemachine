using UnityEngine;
using Assets.Code.States;
using Assets.Code.Interfaces;

public class StateManager : MonoBehaviour {
	private IStateBase activeState;

	// Use this for initialization
	void Start () {
		activeState = new BeginState (this);
		Debug.Log ("This object is of type:" + activeState);
	}
	
	// Update is called once per frame
	void Update () {
		if (activeState != null) {
			activeState.StateUpdate ();
		}
	}
	void OnGUI()
	{
		if (activeState != null)
			activeState.ShowIt ();
	}
	public void SwitchState(IStateBase newState){
		activeState = newState;
	}

}
