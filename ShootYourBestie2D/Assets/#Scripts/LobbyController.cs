using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;
using Photon.Realtime;

public class LobbyController : MonoBehaviourPunCallbacks
{
    public GameObject connectingPanel;

    public TMP_InputField createInput;
    public TMP_InputField joinInput;

    public TextMeshProUGUI playersInRoomText;

    private int playersInRoom;

    void Start()
    {
        connectingPanel.SetActive(false);
    }

    void Update()
    {
        SetPlayerCount();
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.textComponent.ToString());
    }

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createInput.textComponent.ToString());
    }

    private void SetPlayerCount()
    {
        playersInRoomText.text = PhotonNetwork.PlayerList.Length.ToString() + " Players Joined";

        if (PhotonNetwork.PlayerList.Length == 2)
        {
            PhotonNetwork.LoadLevel(2);
        }
    }

    public override void OnJoinedRoom()
    {
        connectingPanel.SetActive(true);
        playersInRoomText.text = PhotonNetwork.PlayerList.Length.ToString() + " Players Joined";
    }
}