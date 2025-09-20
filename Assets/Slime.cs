using UnityEngine;

public class Slime
{
    public int life = 10;
    
    public Slime(int _life)
    {
        life = _life;
    }

    public static Slime operator +(Slime a, Slime b)
    {
        return new Slime(a.life + b.life);
    }
}

