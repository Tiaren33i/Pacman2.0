using UnityEngine;

public class Pellet : MonoBehaviour
{
    public int points = 10;
    protected virtual void Eat()
    {
        FindObjectOfType<GameManager>().PelletEateng(this);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if( other.gameObject.layer == LayerMask.NameToLayer("Pacman"))
        {
            Eat();
        }
    }
}
