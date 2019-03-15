using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domaci2
{
    class Raznostranicni
    {
        private double stranicaA;
        private double stranicaB;
        private double stranicaC;
        private double visinah;

        public Raznostranicni(double aa, double bb, double cc, double hh)
        {

            stranicaA = aa;
            stranicaB = bb;
            stranicaC = cc;
            visinah = hh;
    
        }
        public double StranicaA
        {
            get { return stranicaA; }
            set
            {
                stranicaA = value;
                if (stranicaA < 0)
                {
                    stranicaA = 0;
                }
            }
        }

        public double StranicaB
        {
            get { return stranicaB; }
            set
            {
                stranicaB = value;
                if (stranicaB < 0)
                {
                    stranicaB = 0;
                }
            }
        }

        public double StranicaC 
        {
            get { return stranicaC; }
            set 
            {
                stranicaC = value;
                if(stranicaC < 0)
                {
                    stranicaC = 0;
                }
            }
        }
         public double Visinah
         {
            get{ return visinah; }
            set
            {
                visinah = value;
                if(visinah < 0)
                {
                    visinah = 0;                }
            
                }
         
         
         }

         public virtual double obim() 
         {

             return stranicaA + stranicaB + stranicaC;
         
         }


         public virtual double povrsina() 
         {
             return (stranicaB * visinah) / 2;
         }

        }
        
        
    
    }

