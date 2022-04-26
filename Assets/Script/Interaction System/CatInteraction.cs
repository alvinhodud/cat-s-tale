using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatInteraction : Interactable
{
    public Animator transition;
    public float transitionTime = 1f;
    // Start is called before the first frame update
    public override string GetDescription()
    {
        return "Press [E] to go to next level.";
    }

    public override void Interact()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int nextScene)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(nextScene);
    }
}
