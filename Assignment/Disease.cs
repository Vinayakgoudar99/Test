using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCollectionFrameworkApp.NewFolder1
{
    class Pationts
    {
        public int PationtId { get; set; }
        public string PationtName { get; set; }
        public string Desease { get; set; }
        public string symtoms { get; set; }
    }
    class Desease
    {
        public string DeseaseName { get; set; }
        public string sevearity { get; set; }
        
    }
    class Symtom
    {
        public string DiseaseName { get; set; }
        public string Symtoms { get; set; }
        public string Discription { get; set; }
    }
    interface IMedicalRecApp
    {
       void  AddDesease(Desease desease);
        void AddSymtom(Symtom symtoms);
        void Pationt();
    }
    class MedicalManagement : IMedicalRecApp
    {
        private Desease[] deseases = null;
        private Symtom[] symtoms = null;
        int _size = 0;
        public MedicalManagement(int size)
        {
            _size = size;
            deseases = new Desease[_size];
            symtoms = new Symtom[_size];
        }
   
        public void AddDesease(Desease deseas)
        {
            
            for(int i=0;i< deseases.Length;i++)
            {
                if(deseases[i]==null)
               {
                    deseases[i] = new Desease {DeseaseName=deseas.DeseaseName,sevearity=deseas.sevearity };
                   return;
             
                }
               
            }
           
        }
       
        
        public void AddSymtom(Symtom symtom)
        {
            
            for (int i=0;i<deseases.Length;i++)
            {
                symtoms[i] = new Symtom {DiseaseName=symtom.DiseaseName,Symtoms=symtom.Symtoms,Discription=symtom.Discription };
                return;
            }
            
        }
        public void Pationt()
        {
            Console.WriteLine("enter the name");
            string name = Console.ReadLine();

            Console.WriteLine("enter the symtoms");
            string sym = Console.ReadLine();
            for (int i=0;i<deseases.Length;i++)
            {
               if(symtoms[i].Symtoms.Contains(sym))
                {
                    Console.WriteLine("Desease caused : "+symtoms[i].DiseaseName);
                }
            }
        }
    }
    class MainUi
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());

            MedicalManagement medical = new MedicalManagement(size);
            void addDesease()
            {
                Console.WriteLine(" Enter the Desease Name");
                string desease = Console.ReadLine();

                Console.WriteLine("enter the seviariry");
                string seviarity = Console.ReadLine();

                Desease ds = new Desease { DeseaseName = desease, sevearity = seviarity };
            }

            void addSymtom()
            {
                Console.WriteLine(" Enter the Desease Name");
                string desease = Console.ReadLine();

                Console.WriteLine("entr the symtoms");
                string symtom = Console.ReadLine();

                Console.WriteLine("enter the description");
                string description = Console.ReadLine();

                Symtom s = new Symtom { DiseaseName = desease, Symtoms = symtom, Discription = description };

                medical.AddSymtom(s);
            }
            void pationt()
            {
                medical.Pationt();
            }
            bool processing = true;
            do
            {
                Console.WriteLine("======= medical Research App=============");
                Console.WriteLine("To AddDesease ==> 1\nTo AddSymtoms ==> 2\nTo pationt ==> 3\n");
                Console.WriteLine("enter the option");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        addDesease();
                        break;
                    case "2":
                        addSymtom();
                        break;
                    case "3":
                        pationt();
                        break;
                }
            } while (processing);
         

          
           
           
           

            

           


        }
    }

}
