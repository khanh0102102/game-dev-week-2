using UnityEngine;

public class playerController : MonoBehaviour
{

    public float moveSpeed; // Tốc độ di chuyển của nhân vật.
    public Rigidbody2D rb2d; // Liên kết với component Rigidbody 2D để điều khiển vật lý (di chuyển, va chạm).
    public Vector2 moveInput; // Lưu trữ hướng bấm phím của người chơi (trục X và Y).

    // Các biến trạng thái hướng đi (đang thừa, có thể bỏ)
    public bool movingRight;
    public bool movingLeft;
    public bool movingUp;
    public bool movingDown;


    // Các đối tượng chứa hình ảnh nhân vật quay về 4 hướng
    public GameObject faceR; // Mặt quay sang phải
    public GameObject faceL; // Mặt quay sang trái
    public GameObject faceU; // Mặt quay lên trên
    public GameObject faceD; // Mặt quay xuống dưới

    public Animator playerAnimations; // Liên kết với Animator Controller để kích hoạt các hoạt ảnh (bước đi).

    void Start() { }

    // Update is called once per frame
    void Update()
    {
        // Nhận dữ liệu đầu vào
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        moveInput.Normalize();

        // Ngăn di chuyển chéo
        if (Mathf.Abs(moveInput.x) > Mathf.Abs(moveInput.y))
        {
            moveInput.y = 0;
        }
        else
        {
            moveInput.x = 0;
        }

        // Di chuyển nhân vật
        rb2d.linearVelocity = moveInput * moveSpeed;

        // Xử lý hướng di chuyển và Animation
        if (moveInput.x > 0)
        {
            movingRight = true;
            faceR.SetActive(true);
            faceL.SetActive(false);
            faceD.SetActive(false);
            faceU.SetActive(false);
            playerAnimations.Play("walkR");
        }
        else
        {
            movingRight = false;
        }

        if (moveInput.x < 0)
        {
            movingLeft = true;
            faceL.SetActive(true);
            faceR.SetActive(false);
            faceD.SetActive(false);
            faceU.SetActive(false);
            playerAnimations.Play("walkL");
        }
        else
        {
            movingLeft = false;
        }

        if (moveInput.y > 0)
        {
            movingUp = true;
            faceU.SetActive(true);
            faceD.SetActive(false);
            faceR.SetActive(false);
            faceL.SetActive(false);
            playerAnimations.Play("walkU");
        }
        else
        {
            movingUp = false;
        }

        if (moveInput.y < 0)
        {
            movingDown = true;
            faceD.SetActive(true);
            faceU.SetActive(false);
            faceR.SetActive(false);
            faceL.SetActive(false);
            playerAnimations.Play("walkD");
        }
        else
        {
            movingDown = false;
        }

        // Trạng thái đứng yên (Idle)
        if (moveInput.x == 0 && moveInput.y == 0)
        {
            playerAnimations.Play("playerIdle");
        }
    }
}
