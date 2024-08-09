using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PressButton : MonoBehaviour
{
    private XRBaseInteractable interactable;

    Animator anim;

    private void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        interactable = GetComponent<XRBaseInteractable>();
    }

    private void OnEnable()
    {
        interactable.selectEntered.AddListener(OnButtonPress);
        interactable.selectExited.AddListener(OnButtonRelease);
    }

    private void OnDisable()
    {
        interactable.selectEntered.RemoveListener(OnButtonPress);
        interactable.selectExited.RemoveListener(OnButtonRelease);
    }

    private void OnButtonPress(SelectEnterEventArgs args)
    {
        anim.SetTrigger("Open");
        Debug.Log("Button Pressed!");
    }

    private void OnButtonRelease(SelectExitEventArgs args)
    {
        // Perform your action when the button is released
        Debug.Log("Button Released!");
    }
}
