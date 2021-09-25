


namespace RoleplayGame
{
    public interface ICharacter
    {
        void ReceiveAttack(int power); 
        void Cure();
        string Name { get; set; }
        

    }
}