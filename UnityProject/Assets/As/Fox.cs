using UnityEngine;

public class Fox : MonoBehaviour
{   [Header("移動速度"),Range(0.1f,999f)]
    public float speed = 1f;


    public Rigidbody2D ri;

    public SpriteRenderer sp;








    /// <summary>
    /// 移動
    /// </summary>
    private void spee()
    {
        float speed = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
    }


    private void Update()
    {



       

    }






}
