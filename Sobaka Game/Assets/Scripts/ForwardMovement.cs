using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    public float force = 0.1f; // Сила, с которой бросаем объект

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            
            enabled = false;
        }
    }

    void Update()
    {
        Throw();
    }

    void Throw()
    {
        if (rb != null)
        {
            // Отключаем кинематику, чтобы физика начала работать
            rb.isKinematic = false;
            // Включаем гравитацию
            rb.useGravity = true;

            // Направляем бросок вперед от объекта
            Vector3 direction = transform.forward;

            // Добавляем силу в этом направлении
            rb.AddForce(direction * force, ForceMode.Impulse);
        }
    }
}
