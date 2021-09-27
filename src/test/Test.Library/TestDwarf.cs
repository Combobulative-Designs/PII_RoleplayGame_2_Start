using NUnit.Framework;
using RoleplayGame;



namespace Test.Library
{
    public class TestsDwarf
    {
        [Test]
        public void Test1AtacadoArquero()
        {
            int vida = 100;
            string Nombre = "Nico";
            Dwarf prueba1 = new Dwarf(Nombre);
            Archer arquer1 = new Archer("arquero1");
            arquer1.Bow = new Bow();
            prueba1.Shield = new Shield();
            prueba1.Axe = new Axe();
            prueba1.ReceiveAttack(arquer1.AttackValue);

            Assert.AreEqual(vida,prueba1.Health);

        }

        [Test]
        public void Test2Atacado()
        {
            int vida = 99;
            string Nombre = "Nico";
            Dwarf prueba1 = new Dwarf(Nombre);
            prueba1.Shield = new Shield();
            prueba1.Helmet = new Helmet();
            prueba1.ReceiveAttack(40);
            Assert.AreEqual(vida,prueba1.Health);


        }


        [Test]
        public void Test2curado()
        {
            int vida = 100;
            string Nombre = "Nico";
            Dwarf prueba1 = new Dwarf(Nombre);
    
            prueba1.Shield = new Shield();
            prueba1.Helmet = new Helmet();
            prueba1.ReceiveAttack(50);
        

            prueba1.Cure();
            Assert.AreEqual(vida,prueba1.Health);


        }



    }
}