using UnityEngine;
using Photon.Pun;

public class GameController : MonoBehaviour
{
    public GameObject player;

    private float maxX = 7f;
    private float minX = -7f;
    private float maxY = 3f;
    private float minY = -3f;

    void Start()
    {
        SpawnPlayer();
    }

    void SpawnPlayer()
    {
        PhotonNetwork.Instantiate(player.name, new Vector3(Random.Range(maxX, minX), Random.Range(minY, maxY), 0f), Quaternion.identity);
    }

    
}