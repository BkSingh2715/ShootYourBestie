using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class LobbyController : MonoBehaviour
{
    private string createRoomName;
    private string joinRoomName;

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createRoomName);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinRoomName);
    }

    public void OnJoinedRoom()
    {
        print("joined");
    }
}
