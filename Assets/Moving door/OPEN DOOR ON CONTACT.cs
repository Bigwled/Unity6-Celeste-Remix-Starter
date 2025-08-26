using UnityEngine;

public class OPENDOORONCONTACT : MonoBehaviour
{ 
    public Animator animator;
    private bool isTripped = false;

    private void start()
    {
        isTripped = false;
    }
    
    private  void OnTriggerEnter2D(Collider2D col)
    {
         if (col.gameObject.tag == "Player" && isTripped == false) 
        {
             animator.SetTrigger("Open");
             isTripped = true;

        }
    }
}
