using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour
{
    public Transform player;
    [SerializeField]
    private float Speed = 10f;

    void OnMouseDrag()
    {
        if (!Player.lose)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.x = mousePos.x > 2 ? 2 : mousePos.x;
            mousePos.x = mousePos.x < -2 ? -2 : mousePos.x;
            player.position = Vector2.MoveTowards(player.position,
                new Vector2(mousePos.x, player.position.y),
                Speed * Time.deltaTime);
        }
    }
}
