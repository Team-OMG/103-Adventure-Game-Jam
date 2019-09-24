using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject[] Player_Inventory;
    public Collider Player;

    void Update()
    {
        
    }

    public void SlotControl()
    {
        // Receives data from another script that holds how many slots are currently available.
        // Mechanic-wise, there are only 4 slots in the player's inventory.
        // These slots will be unlocked by the player through story progression
    }

    public void GetItem()
    {
        // Put item into inventory
    }
}
