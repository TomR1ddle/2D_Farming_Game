using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class Toolbar_UI : MonoBehaviour
{
    [SerializeField] private List<Slots_UI> toolbarSlots = new List<Slots_UI>();

    private Slots_UI selectedSlot;

    private void Start()
    {
        SelectSlot(0);
    }
    private void Update()
    {
        CheckAlphaNumbericKeys();
    }

    public void SelectSlot(int index)
    {
        if(toolbarSlots.Count == 9)
        {
            if (selectedSlot != null)
            {
                selectedSlot.SetHighlight(false);
            }

            selectedSlot = toolbarSlots[index];
            selectedSlot.SetHighlight(true);
            Debug.Log("Slot: " + selectedSlot.name);
        }
    }

    private void CheckAlphaNumbericKeys()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            SelectSlot(0);
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            SelectSlot(1);
        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            SelectSlot(2);
        }
        if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            SelectSlot(3);
        }
        if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            SelectSlot(4);
        }
        if (Input.GetKeyUp(KeyCode.Alpha6))
        {
            SelectSlot(5);
        }
        if (Input.GetKeyUp(KeyCode.Alpha7))
        {
            SelectSlot(6);
        }
        if (Input.GetKeyUp(KeyCode.Alpha8))
        {
            SelectSlot(7);
        }
        if (Input.GetKeyUp(KeyCode.Alpha9))
        {
            SelectSlot(8);
        }
    }
}
