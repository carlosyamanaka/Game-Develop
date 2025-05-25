using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private Vector2 posInitial;
    public float displacement = 2;
    private float i = 0;

    private void Start()
    {
        posInitial = transform.position;
    }

    private void Update()
    {
        float x = Mathf.Sin(i);
        float y = Mathf.Cos(i);

        transform.position = new Vector2(posInitial.x + x, posInitial.y + y);
        i += displacement * Time.deltaTime;

        if (cont > 2 * Mathf.PI)
        {
            i = 0;
        }
    }
}
