using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ProjectorInteraction : MonoBehaviour
{
    public GameObject particules;
    public void OnSelectEnter(XRBaseInteractor interactor)
        {
            if (!particules.activeInHierarchy)
            {
                particules.SetActive(true);
            }
            else
            {
                particules.SetActive(false);
            }
        }
}
