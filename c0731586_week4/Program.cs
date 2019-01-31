using System;

namespace c0731586_week4
{
    class Program
    {
        static void Main(string[] args)
        {
            countrySide Ontario = new countrySide();
            Ontario.run ();
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

        class countrySide
        {
            public Village Maple;
            public Village Toronto;
            public Village Ajax;
            public Village Head;
            public Village Tail;
            public Village Temp;

            public void run()
            {
                this.Mapinitializer();
                 this.LookForAstridile();
             }

            private void LookForAstridile()
            {
                throw new NotImplementedException();
            }

            private void Mapinitializer()
            {
                throw new NotImplementedException();
            }

            public void MapinInitializer()
            {
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
               // Ajax.isAstrildeHere = true;



            }


            public void LookForAstridileHere()
            {


                Head = Maple;
                if (Head.isAstrildeHere)

                {
                    Console.WriteLine("Yeah !! Astrilde is in " + Head.VillageName);
                }
               // while (true)

               // {

               // }






            }
        }

    }
}

