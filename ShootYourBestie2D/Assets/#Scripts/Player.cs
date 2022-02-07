using Photon.Pun;
using UnityEngine;

public class Player : MonoBehaviour
{
    private SpriteRenderer myRenderer;
    private Rigidbody2D myBody;

    PhotonView myView;

    private Color[] spawnColors;

    private float moveSpeed = 5f;
    private float jumpForce = 1000f;

    void Start()
    {
        myRenderer = gameObject.GetComponent<SpriteRenderer>();
        myBody = gameObject.GetComponent<Rigidbody2D>();
        myView = gameObject.GetComponent<PhotonView>();

        spawnColors = new Color[] { Color.red, Color.green, Color.gray, Color.yellow };
        myRenderer.color = spawnColors[Random.Range(0, spawnColors.Length - 1)];
    }

    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        if (myView.IsMine)
        {
            transform.Translate(new Vector2(moveSpeed * Input.GetAxisRaw("Horizontal") * Time.deltaTime, 0f));

            if (Input.GetKeyDown(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                myBody.AddForce(new Vector2(0f, jumpForce));
            }
        }
    }
}