using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptrón
{
    class Herramientas
    {
        public double w1 { get; private set; }
        public double w2 { get; private set; }
        public double bias { get; private set; }
        Random aleatorio = new Random();
     


        public Herramientas(double wi1, double wi2, double bbias)
        {

            this.w1=wi1;
            this.w2=wi2;
            this.bias=bbias;
        }


        public double sacarNP(double i1, double i2)
        {
            double np = (i1 * w1) + (i2 * w2) + bias;
            return np;
            
            /*npi=i1*w1+i2*w2+bias
            fpi==T1
            fp1=/=t1
            E=t1-fp1
            nuevoW1=viejoW1+E(i1)
            bias = viejoBias + E;*/
        }

       

        public double sacarFP(double np)
        {
            if (np >= 0)return 1;
            else  return 0;
        }

        public Boolean comprobarT(double fp, double t)
        {
            if (fp == t) return true;
            else return false;
        }

        public void sacarErrorYW1W2Bias(double t, double fp, double i1, double i2)
        {
            double auxW1=0, auxW2=0, auxBias=0;
            double E = t - fp;
            auxW1 = this.w1 + (E*i1);
            auxW2 = this.w2 + (E*i2);
            auxBias = bias + E;
            this.w1 = auxW1;
            this.w2 = auxW2;
            this.bias = auxBias;
        }

    }
}
