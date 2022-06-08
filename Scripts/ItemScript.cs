using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    public ItemTypes itemType;
    public int resourceNumber = 1;
}

public enum ItemTypes
{
    Diamond,
    Adamantium,
    Vibranium
}