using UnityEngine;
using System.Runtime.InteropServices;

public class Watch : MonoBehaviour {

	
	public void OpenLinkJSPluginF() {
		#if !UNITY_EDITOR
		openWindowF("http://www.playlookingglass.com/watch");
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindowF(string url);


	
	/*
	void Update()
	{

	openWindowF();
	
	}
	
    [DllImport("__Internal")]
	private static extern void openWindowF();
    
*/


}