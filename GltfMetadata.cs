using UnityEngine;

[System.Serializable]
public class GltfMetadata : MonoBehaviour
{
    [Header("General Info")]
    public string objectId;
    public string category;

    [Header("Additional Details")]
    [TextArea]
    public string description;
    public string tags; // เช่น "heavy, metal, interactable"
}
