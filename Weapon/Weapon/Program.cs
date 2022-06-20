// See https://aka.ms/new-console-template for more information
class Weapon
{
    private int _damage;
    private int _bullets;

    private void Reload()
    {
        _bullets = 30;
    }

    public void Fire(Player player)
    {
        if (_bullets != 0)
            player.TakeDamage(_damage);

        else
            Reload();
    }
}

class Player
{
    private int _health;

    public void TakeDamage(int damage)
    {
        _health -= damage;
    }
}

class Bot
{
    private Weapon _weapon;

    public void OnSeePlayer(Player player)
    {
        _weapon.Fire(player);
    }
}
