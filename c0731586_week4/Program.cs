using System;

namespace c0731586_week4
{
    class Program
    {
        static void Main(string[] args)
        {

            countrySide Ontario = new countrySide();
            Ontario.run();

        }
    }

    class LearningExample
    {
        public void run()
        {
            Village Toronto;
            Village a;
            Village b;
            Toronto = new Village();
            a = Toronto;

            Toronto = new Village();
            b = Toronto;

            if (a == b) { Console.WriteLine("same"); }
            else
            { Console.WriteLine("different obj refs"); }
        }
    }



    class Village

    {
        public static int numberofVillages = 0;
        public Village nextVillage;
        public Village previousVillage;
        public string VillageName;
        public bool isAstrildeHere = false;

        public Village()
        {
            Village.numberofVillages++;

        }
    }

        class countrySide
        {
            public Village Maple;
            public Village Toronto;
            public Village Ajax;
            public Village Head;
            public Village Tail;
            public Village Current;

            public void run()
            {
                this.MapInitializer();
                this.LookForAstridileHere();
                Console.WriteLine("Hugi found Astrilde in " + Current.VillageName);
            }

            
            public void MapInitializer()
            {

            Ajax = new Village();
            Toronto = new Village();
            Maple = new Village();


            Maple = new Village();
                Maple.VillageName = "Maple";
                Maple.previousVillage = null;

                Maple.nextVillage = Toronto;
                Maple.isAstrildeHere = true;
                Toronto = new Village();
                Toronto.previousVillage = Maple;
                Toronto.nextVillage = Ajax;
                Ajax = new Village();
                Ajax.VillageName = "Ajax";
                Ajax.previousVillage = Toronto;
                Ajax.nextVillage = null;
               

            }


            public void LookForAstridileHere()
            {


                Current = Maple;
                while (Current.nextVillage !=null)
                {
                if (Current.isAstrildeHere)
                {
                    Console.WriteLine("found Astridle");
                    Console.ReadLine();
                    return;
                }
                else
                {

                    Current = Current.nextVillage;
            }
                // while (true)

                // {

                // }

            }
        }

    }
}

