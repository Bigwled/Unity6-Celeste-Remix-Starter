using UnityEngine;
void OnCollisionEnter(Collision Col)
{ 
if (Col.collider.gameObject.CompareTag("Triangle"))
{
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
}