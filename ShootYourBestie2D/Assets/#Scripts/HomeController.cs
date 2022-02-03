using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;

public class HomeController : MonoBehaviourPunCallbacks
{
    public GameObject connectorPanel;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();

        connectorPanel.SetActive(true);
    }

    public void LoadLobby()
    {
        SceneManager.LoadScene(1);
    }
    
    public override void OnConnectedToMaster()
    {
        connectorPanel.SetActive(false);
        print("CONNECTED");

        PhotonNetwork.JoinLobby();
    }
}