using UnityEngine;
using System.Collections;

public class SerialHandlerTest : MonoBehaviour {

	public SerialHandler serialHandler_;

	void Start()
	{
		serialHandler_.OnDataReceived += OnDataReceived;
	}

	void OnDataReceived(string message)
	{
		//you could define your start and end character to separate the message properly
		Debug.Log (message);

	}
}
