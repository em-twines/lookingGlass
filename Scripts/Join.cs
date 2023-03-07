using UnityEngine;
using System.Runtime.InteropServices;

public class Join : MonoBehaviour {


	public void OpenLinkJSPluginT() {
		#if !UNITY_EDITOR
		openWindowT("https://us02web.zoom.us/j/7283544436");
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindowT(string url);
	


/*
	void Update()
	{

	openWindowT();
	
	}

    [DllImport("__Internal")]
	private static extern void openWindowT();
    

*/

}