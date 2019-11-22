using UnityEngine;

public class Fox : MonoBehaviour
{   [Header("移動速度"),Range(0.1f,999f)]
    public float speed = 1f;


    public Rigidbody2D ri;

    public SpriteRenderer sp;



    public Transform fox;




    /// <summary>
    /// 移動
    /// </summary>
    private void Spee()
    {
        float d = Input.GetAxisRaw("Horizontal") * Time.deltaTime;

        fox.Rotate(0, d*speed, 0);
    }


    private void Update()
    {
        Spee();





    }





    
}
