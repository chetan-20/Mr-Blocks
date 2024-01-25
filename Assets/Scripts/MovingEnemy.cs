
using UnityEngine;

public class MovingEnemy : MonoBehaviour
{
    public Transform enemy;
    public Transform pointa;
    public Transform pointb;
    int direction = 1;
    public float speed;
    private void Update()
    {
        Vector2 Target = CurrenTarget();
        enemy.position = Vector2.Lerp(enemy.position, Target, speed * Time.deltaTime);
        float distance = (Target-(Vector2)enemy.position).magnitude;
        if(distance <= 0.1f)
        {
            direction *= -1;
        }
    }
    Vector2 CurrenTarget()
    {
        if(direction == 1 ) {
            return pointa.position;
        }
        else
        {
            return pointb.position;
        }
    }
}
