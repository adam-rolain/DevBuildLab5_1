using System;

namespace Lab5_1RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            // TESTING GAMECHARACTER CLASS
            Console.WriteLine("\n----------GameCharacterTest-----------");
            GameCharacter character1 = new GameCharacter("Voldemort", 82, 99);
            character1.Play();
            GameCharacter character2 = new GameCharacter("Harry Potter", -10, 50);
            character2.Play();
            GameCharacter character3 = new GameCharacter("Hermoine Granger", -50, 101);
            character3.Play();
            GameCharacter character4 = new GameCharacter(null , -10, 50);
            character4.Play();

            // TESTING MAGICUSINGCHARACTER
            Console.WriteLine("\n----------MagicUsingCharacterTest-----------");
            MagicUsingCharacter mCharacter1 = new MagicUsingCharacter("Voldemort", 82, 99, 75);
            mCharacter1.Play();
            MagicUsingCharacter mCharacter2 = new MagicUsingCharacter("Harry Potter", -10, 50, -1);
            mCharacter2.Play();
            MagicUsingCharacter mCharacter3 = new MagicUsingCharacter("Hermoine Granger", -50, 101, 101);
            mCharacter3.Play();
            MagicUsingCharacter mCharacter4 = new MagicUsingCharacter(null, -10, 50, 82);
            mCharacter4.Play();

            // TESTING WIZARD CLASS
            Console.WriteLine("\n----------WizardTest-----------");
            Wizard wizard1 = new Wizard("Voldemort", 82, 99, 75, 82);
            wizard1.Play();
            Wizard wizard2 = new Wizard("Harry Potter", -10, 50, -1, -1);
            wizard2.Play();
            Wizard wizard3 = new Wizard("Hermoine Granger", -50, 101, 101, 101);
            wizard3.Play();
            Wizard wizard4 = new Wizard(null, -10, 50, 82, 96);
            wizard4.Play();

            // TESTING Warrior CLASS
            Console.WriteLine("\n----------WarriorTest-----------");
            Warrior warrior1 = new Warrior("Jon Snow", 82, 99, "Sword");
            warrior1.Play();
            Warrior warrior2 = new Warrior("Private Ryan", -10, 50, "Gun");
            warrior2.Play();
            Warrior warrior3 = new Warrior("Inigo Montoya", -50, 101, "");
            warrior3.Play();
            Warrior warrior4 = new Warrior(null, -10, 50, null);
            warrior4.Play();
        }
    }

    class GameCharacter
    {
        // PRIVATE MEMBERS
        private string pName;
        private int pStrength;
        private int pIntelligence;

        // CONSTRUCTORS
        public GameCharacter(string Name, int Strength, int Intelligence)
        {
            SetName(Name);
            SetStrength(Strength);
            SetIntelligence(Intelligence);
        }

        // GETTERS AND SETTERS
        public string GetName()
        {
            return pName;
        }

        public void SetName(string Name)
        {
            if (!String.IsNullOrEmpty(Name))
            {
                pName = Name;
            }
            else
            {
                pName = "EMPTY";
            }
        }
        public int GetStrength()
        {
            return pStrength;
        }

        public void SetStrength(int Strength)
        {
            if (Strength < 0)
            {
                pStrength = 0;
            }
            else if (Strength > 100)
            {
                pStrength = 100;
            }
            else
            {
                pStrength = Strength;
            }
        }
        public int GetIntelligence()
        {
            return pIntelligence;
        }
        public void SetIntelligence(int Intelligence)
        {
            if (Intelligence < 0)
            {
                pIntelligence = 0;
            }
            else if (Intelligence > 100)
            {
                pIntelligence = 100;
            }
            else
            {
                pIntelligence = Intelligence;
            }
        }

        // METHODS
        public virtual void Play()
        {
            Console.WriteLine($"\n{pName} (Intelligence: {pIntelligence}, Strength: {pStrength})");
        }
    }

    class MagicUsingCharacter : GameCharacter
    {
        // PRIVATE MEMBERS
        private int pMagicalEnergy;

        //CONSTRUCTORS
        public MagicUsingCharacter(string Name, int Strength, int Intelligence, int MagicalEnergy) : base(Name, Strength, Intelligence)
        {
            SetMagicalEnergy(MagicalEnergy);
        }

        // GETTERS AND SETTERS
        public int GetMagicalEnergy()
        {
            return pMagicalEnergy;
        }
        public void SetMagicalEnergy(int MagicalEnergy)
        {
            if (MagicalEnergy < 0)
            {
                pMagicalEnergy = 0;
            }
            else if (MagicalEnergy > 100)
            {
                pMagicalEnergy = 100;
            }
            else
            {
                pMagicalEnergy = MagicalEnergy;
            }
        }

        // METHODS
        public override void Play()
        {
            Console.WriteLine($"\n{GetName()} (Intelligence: {GetIntelligence()}, Strength: {GetStrength()}, Magic: {pMagicalEnergy})");
        }
    }

    class Wizard : MagicUsingCharacter
    {
        // PRIVATE MEMBERS
        private int pSpellNumber;

        // CONSTRUCTORS
        public Wizard(string Name, int Strength, int Intelligence, int MagicalEnergy, int SpellNumber) : base(Name, Strength, Intelligence, MagicalEnergy)
        {
            SetSpellNumber(SpellNumber);
        }

        // GETTERS AND SETTERS
        public int GetSpellNumber()
        {
            return pSpellNumber;
        }
        public void SetSpellNumber(int SpellNumber)
        {
            if (SpellNumber < 0)
            {
                pSpellNumber = 0;
            }
            else if (SpellNumber > 100)
            {
                pSpellNumber = 100;
            }
            else
            {
                pSpellNumber = SpellNumber;
            }
        }

        // METHODS
        public override void Play()
        {
            Console.WriteLine($"\n{GetName()} (Intelligence: {GetIntelligence()}, Strength: {GetStrength()}, Magic: {GetMagicalEnergy()}) {pSpellNumber} spells");
        }
    }

    class Warrior : GameCharacter
    {
        // PRIVATE MEMBERS
        private string pWeaponType;

        // CONSTRUCTORS
        public Warrior(string Name, int Strength, int Intelligence, string WeaponType) : base(Name, Strength, Intelligence)
        {
            SetWeaponType(WeaponType);
        }

        // GETTERS AND SETTERS
        public string GetWeaponType()
        {
            return pWeaponType;
        }
        public void SetWeaponType(string WeaponType)
        {
            if (!String.IsNullOrEmpty(WeaponType))
            {
                pWeaponType = WeaponType;
            }
            else
            {
                pWeaponType = "EMPTY";
            }
        }

        // METHODS
        public override void Play()
        {
            Console.WriteLine($"\n{GetName()} (Intelligence: {GetIntelligence()}, Strength: {GetStrength()}) {pWeaponType}");
        }
    }
}
