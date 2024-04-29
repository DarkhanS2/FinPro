using UnityEngine;

public class MinionCard : Card
{
    public int attack;
    public int health;

    public override void Play()
    {
        // Logica dlya razigrivaniya karti miniona na pole
    }

    public void Attack(MinionCard target)
    {
        target.health -= this.attack;
        if (target.health <= 0)
        {
            Destroy(target.gameObject);  // Ubirat' miniona s polya srazheniya
        }
    }
}
