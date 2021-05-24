using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject moleContainer;

    private Mole[] moles;
    void Start()
    {
        moles = moleContainer.GetComponentsInChildren<Mole>();
        moles[Random.Range(0, moles.Length)].Rise();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
