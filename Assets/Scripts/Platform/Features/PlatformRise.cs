using UnityEngine;

public class PlatformRise : MonoBehaviour
{
    // PlatformRise

    [SerializeField, Range(0f, 10f)] float speed = 1f;

    // === API === //
    public void Rising()
    {
        Vector2 rising = Vector2.up * speed;

        transform.Translate(rising * Time.deltaTime);
    }
}
