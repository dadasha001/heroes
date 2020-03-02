using System;

namespace Assets.Scripts.Models
{
    public static class Settings
    {
        public static class Detachments 
        {
            public static int Limit = 7;
        }

        public static class Grid
        {
            public static int Width = 10;
            public static int Height = 7;
        }

        public static class Units
        {
            public static Skills Parameters(Unit.Type type)
            {
                if (type == Unit.Type.Archer)
                    return new Skills(damage: 7, defence: 7, speed: 4);
                if (type == Unit.Type.Dragon)
                    return new Skills(damage: 10, defence: 10, speed: 10);
                if (type == Unit.Type.Infantry)
                    return new Skills(damage: 5, defence: 5, speed: 5);
                if (type == Unit.Type.Knight)
                    return new Skills(damage: 8, defence: 8, speed: 6);
                if (type == Unit.Type.Wizard)
                    return new Skills(damage: 6, defence: 5, speed: 3);

                throw new Exception($"Invalid unit type: {type}.");
            }

            public static int Health(Unit.Type type)
            {
                if (type == Unit.Type.Archer)
                    return 10;
                if (type == Unit.Type.Dragon)
                    return 100;
                if (type == Unit.Type.Infantry)
                    return 10;
                if (type == Unit.Type.Knight)
                    return 35;
                if (type == Unit.Type.Wizard)
                    return 30;

                throw new Exception($"Invalid unit type: {type}.");
            }
        }
    }
}
