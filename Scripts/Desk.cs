
using UnityEngine;
using UnityEngine.UI;

public class Desk : MonoBehaviour
{

  private void Awake()
  {
     GameObject.Find("CanvasOffice").transform.GetChild(1).gameObject.SetActive(false);

  }
    private void OnTriggerEnter(Collider other)
    {
      GameObject.Find("CanvasOffice").transform.GetChild(1).gameObject.SetActive(true);
  
    }    
    
   private void OnTriggerExit()
   {
     GameObject.Find("CanvasOffice").transform.GetChild(1).gameObject.SetActive(false);

   }



    // Application.OpenURL("window.open(\"https://repl.it/@emilytwines\",\"_blank\")");
      //  Application.OpenURL("https://repl.it/@emilytwines/Look");
    
}
