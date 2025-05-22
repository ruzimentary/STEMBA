using UnityEngine;

public enum AvatarRole
{
    Peer,
    Teacher,
    Parent
}

public class AvatarManager : MonoBehaviour
{
    public AvatarRole currentRole = AvatarRole.Peer;

    void Start()
    {
        Debug.Log("Current Avatar Role: " + currentRole);
    }

    public void SetRole(AvatarRole role)
    {
        currentRole = role;
        Debug.Log("Switched to role: " + currentRole);
    }
}
