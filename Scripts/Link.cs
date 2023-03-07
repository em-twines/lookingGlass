using UnityEngine;
using System.Runtime.InteropServices;

public class Link : MonoBehaviour 
{
	public void OpenLinkJSPlugin() {
        Debug.Log("link called");
		#if !UNITY_EDITOR
		openWindow("https://repl.it/@emilytwines/Look?lite=true&outputonly=true");
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);
}