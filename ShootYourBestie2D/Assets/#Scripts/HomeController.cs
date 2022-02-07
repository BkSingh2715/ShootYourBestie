using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;

public class HomeController : MonoBehaviourPunCallbacks
{
    public GameObject connectorPanel;

    private bool joined = false;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();

        connectorPanel.SetActive(true);
    }

    public void LoadLobby()
    {
        if(joined)
            SceneManager.LoadScene(1);
    }
    
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        connectorPanel.SetActive(false);
        print("CONNECTED AND JOINED");

        joined = true;
    }
}