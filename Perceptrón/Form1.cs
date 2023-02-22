using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perceptrón
{
    public partial class Form1 : Form
    {
        Herramientas ehiiiiiii;
        Random r1 = new Random();
        int ri1, ri2, rb;
        double randomDouble1 = 0;
        double randomDouble2 = 0;
        double randomDoubleB = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BOR_Click(object sender, EventArgs e)
        {
            int[,] matrizCompuertaOR = new int[,] { { 0, 0, 0 }, { 0, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 } };
            ri1 = r1.Next(-10, 10);
            ri2 = r1.Next(-10, 10);
            rb = r1.Next(-10, 10);


            if (ri1 >= 0)
            {
                randomDouble1 = r1.NextDouble() + ri1;
                TBEntrada1.Text = randomDouble1.ToString();
            }
            else
            {
                randomDouble1 = (-1 * r1.NextDouble()) + ri1;
                TBEntrada1.Text = randomDouble1.ToString();
            }

            if (ri2 >= 0)
            {
                randomDouble2 = r1.NextDouble() + ri2;
                TBEntrada2.Text = randomDouble2.ToString();
            }
            else
            {
                randomDouble2 = (-1 * r1.NextDouble()) + ri2;
                TBEntrada2.Text = randomDouble2.ToString();
            }

            if (rb >= 0)
            {
                randomDoubleB = r1.NextDouble() + rb;
                TBBias.Text = randomDoubleB.ToString();
            }
            else
            {
                randomDoubleB = (-1 * r1.NextDouble()) + rb;
                TBBias.Text = randomDoubleB.ToString();
            }

            ehiiiiiii = new Herramientas(randomDouble1, randomDouble2, randomDoubleB);
            double npi1 = 0, npi2 = 0, npi3 = 0, npi4 = 0;
            double fp1 = 0, fp2 = 0, fp3 = 0, fp4 = 0;
            Boolean banderitaNpi1 = false, banderitaNpi2 = false, banderitaNpi3 = false, banderitaNpi4 = false;
            do //ciclo np4
            {
                //LW1.Text = (ehiiiiiii.sacarNP(matrizCompuertaOR[0, 0], matrizCompuertaOR[0, 1])).ToString();


                do//ciclo np3
                {
                    do//ciclo np2
                    {
                        do//ciclo np1
                        {

                            npi1 = ehiiiiiii.sacarNP(matrizCompuertaOR[0, 0], matrizCompuertaOR[0, 1]);
                            fp1 = ehiiiiiii.sacarFP(npi1);
                            if (ehiiiiiii.comprobarT(fp1, matrizCompuertaOR[0, 2]) == false)
                            {
                                ehiiiiiii.sacarErrorYW1W2Bias(matrizCompuertaOR[0, 2], fp1, matrizCompuertaOR[0, 0], matrizCompuertaOR[0, 1]);
                                banderitaNpi1 = false;
                            }
                            else
                            {
                                banderitaNpi1 = true;
                            }
                        } while (banderitaNpi1 == false);

                        npi2 = ehiiiiiii.sacarNP(matrizCompuertaOR[1, 0], matrizCompuertaOR[1, 1]);
                        fp2 = ehiiiiiii.sacarFP(npi2);
                        if (ehiiiiiii.comprobarT(fp2, matrizCompuertaOR[1, 2]) == false)
                        {
                            ehiiiiiii.sacarErrorYW1W2Bias(matrizCompuertaOR[1, 2], fp2, matrizCompuertaOR[1, 0], matrizCompuertaOR[1, 1]);
                            banderitaNpi2 = false;
                            banderitaNpi1 = false;
                        }
                        else
                        {
                            banderitaNpi2 = true;
                        }

                    } while (banderitaNpi2 == false);

                    npi3 = ehiiiiiii.sacarNP(matrizCompuertaOR[2, 0], matrizCompuertaOR[2, 1]);
                    fp3 = ehiiiiiii.sacarFP(npi3);
                    if (ehiiiiiii.comprobarT(fp3, matrizCompuertaOR[2, 2]) == false)
                    {
                        ehiiiiiii.sacarErrorYW1W2Bias(matrizCompuertaOR[2, 2], fp3, matrizCompuertaOR[2, 0], matrizCompuertaOR[2, 1]);
                        banderitaNpi3 = false;
                        banderitaNpi1 = false;
                        banderitaNpi2 = false;
                    }
                    else
                    {
                        banderitaNpi3 = true;
                    }

                } while (banderitaNpi3 == false);

                npi4 = ehiiiiiii.sacarNP(matrizCompuertaOR[3, 0], matrizCompuertaOR[3, 1]);
                fp4 = ehiiiiiii.sacarFP(npi4);
                if (ehiiiiiii.comprobarT(fp4, matrizCompuertaOR[3, 2]) == false)
                {
                    ehiiiiiii.sacarErrorYW1W2Bias(matrizCompuertaOR[3, 2], fp4, matrizCompuertaOR[3, 0], matrizCompuertaOR[3, 1]);
                    banderitaNpi4 = false;
                    banderitaNpi1 = false;
                    banderitaNpi2 = false;
                    banderitaNpi3 = false;
                }
                else
                {
                    banderitaNpi4 = true;
                }

            } while (banderitaNpi4 == false);
            // Do While se hace mientras se esté cumpliendo lo que se pide

            label4.Text = matrizCompuertaOR[0, 0].ToString();
            label5.Text = matrizCompuertaOR[0, 1].ToString();
            label6.Text = matrizCompuertaOR[0, 2].ToString();
            label17.Text = fp1.ToString();


            label10.Text = matrizCompuertaOR[1, 0].ToString();
            label9.Text = matrizCompuertaOR[1, 1].ToString();
            label8.Text = matrizCompuertaOR[1, 2].ToString();
            label18.Text = fp2.ToString();

            label13.Text = matrizCompuertaOR[2, 0].ToString();
            label12.Text = matrizCompuertaOR[2, 1].ToString();
            label11.Text = matrizCompuertaOR[2, 2].ToString();
            label19.Text = fp3.ToString();

            label16.Text = matrizCompuertaOR[3, 0].ToString();
            label15.Text = matrizCompuertaOR[3, 1].ToString();
            label14.Text = matrizCompuertaOR[3, 2].ToString();
            label20.Text = fp4.ToString();
            TBW1Final.Text = ehiiiiiii.w1.ToString();
            TBW2Final.Text = ehiiiiiii.w2.ToString();
            TBBiasFinal.Text = ehiiiiiii.bias.ToString();
        }

        private void TBEntrada1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BInicio_Click(object sender, EventArgs e)
        {
            int[,] matrizCompuertaAND = new int[,] { { 0, 0, 0 }, { 0, 1, 0 }, { 1, 0, 0 }, { 1, 1, 1 } };
            ri1 = r1.Next(-10, 10);
            ri2 = r1.Next(-10, 10);
            rb = r1.Next(-10, 10);

           
            if (ri1 >= 0)
            {
                randomDouble1 = r1.NextDouble() + ri1;
                TBEntrada1.Text = randomDouble1.ToString();
            }
            else
            {
                randomDouble1 = (-1*r1.NextDouble()) + ri1;
                TBEntrada1.Text = randomDouble1.ToString();
            }

            if (ri2 >= 0)
            {
                randomDouble2 = r1.NextDouble() + ri2;
                TBEntrada2.Text = randomDouble2.ToString();
            }
            else
            {
                randomDouble2 = (-1 * r1.NextDouble()) + ri2;
                TBEntrada2.Text = randomDouble2.ToString();
            }

            if (rb >= 0)
            {
                randomDoubleB = r1.NextDouble() + rb;
                TBBias.Text = randomDoubleB.ToString();
            }
            else
            {
                randomDoubleB = (-1 * r1.NextDouble()) + rb;
                TBBias.Text = randomDoubleB.ToString();
            }
            
            ehiiiiiii = new Herramientas(randomDouble1, randomDouble2, randomDoubleB);
            double npi1 = 0, npi2=0, npi3=0, npi4=0;
            double fp1 = 0, fp2=0, fp3=0, fp4=0;
            Boolean banderitaNpi1=false, banderitaNpi2=false, banderitaNpi3=false, banderitaNpi4=false;
            do //ciclo np4
            {
                //LW1.Text = (ehiiiiiii.sacarNP(matrizCompuertaAND[0, 0], matrizCompuertaAND[0, 1])).ToString();


                do//ciclo np3
                {
                    do//ciclo np2
                    {
                        do//ciclo np1
                        {
                            
                            npi1= ehiiiiiii.sacarNP(matrizCompuertaAND[0, 0], matrizCompuertaAND[0, 1]);
                            fp1 = ehiiiiiii.sacarFP(npi1);
                            if(ehiiiiiii.comprobarT(fp1, matrizCompuertaAND[0, 2]) == false)
                            {
                                ehiiiiiii.sacarErrorYW1W2Bias(matrizCompuertaAND[0, 2],fp1, matrizCompuertaAND[0, 0], matrizCompuertaAND[0, 1]);
                                banderitaNpi1 = false;
                            }
                            else
                            {
                                banderitaNpi1 = true;
                            }
                        } while (banderitaNpi1==false);

                        npi2 = ehiiiiiii.sacarNP(matrizCompuertaAND[1, 0], matrizCompuertaAND[1, 1]);
                        fp2 = ehiiiiiii.sacarFP(npi2);
                        if (ehiiiiiii.comprobarT(fp2, matrizCompuertaAND[1, 2]) == false)
                        {
                            ehiiiiiii.sacarErrorYW1W2Bias(matrizCompuertaAND[1, 2], fp2, matrizCompuertaAND[1, 0], matrizCompuertaAND[1, 1]);
                            banderitaNpi2 = false;
                            banderitaNpi1 = false;
                        }
                        else
                        {
                            banderitaNpi2 = true;
                        }

                    } while (banderitaNpi2==false);

                    npi3 = ehiiiiiii.sacarNP(matrizCompuertaAND[2, 0], matrizCompuertaAND[2, 1]);
                    fp3 = ehiiiiiii.sacarFP(npi3);
                    if (ehiiiiiii.comprobarT(fp3, matrizCompuertaAND[2, 2]) == false)
                    {
                        ehiiiiiii.sacarErrorYW1W2Bias(matrizCompuertaAND[2, 2], fp3, matrizCompuertaAND[2, 0], matrizCompuertaAND[2, 1]);
                        banderitaNpi3 = false;
                        banderitaNpi1 = false;
                        banderitaNpi2 = false;
                    }
                    else
                    {
                        banderitaNpi3 = true;
                    }

                } while (banderitaNpi3==false);

                npi4 = ehiiiiiii.sacarNP(matrizCompuertaAND[3, 0], matrizCompuertaAND[3, 1]);
                fp4 = ehiiiiiii.sacarFP(npi4);
                if (ehiiiiiii.comprobarT(fp4, matrizCompuertaAND[3, 2]) == false)
                {
                    ehiiiiiii.sacarErrorYW1W2Bias(matrizCompuertaAND[3, 2], fp4, matrizCompuertaAND[3, 0], matrizCompuertaAND[3, 1]);
                    banderitaNpi4 = false;
                    banderitaNpi1 = false;
                    banderitaNpi2 = false;
                    banderitaNpi3 = false;
                }
                else
                {
                    banderitaNpi4 = true;
                }

            } while (banderitaNpi4==false);
            // Do While se hace mientras se esté cumpliendo lo que se pide



            label4.Text = matrizCompuertaAND[0, 0].ToString();
            label5.Text = matrizCompuertaAND[0, 1].ToString();
            label6.Text = matrizCompuertaAND[0, 2].ToString();
            label17.Text = fp1.ToString();


            label10.Text = matrizCompuertaAND[1, 0].ToString();
            label9.Text = matrizCompuertaAND[1, 1].ToString();
            label8.Text = matrizCompuertaAND[1, 2].ToString();
            label18.Text = fp2.ToString();

            label13.Text = matrizCompuertaAND[2, 0].ToString();
            label12.Text = matrizCompuertaAND[2, 1].ToString();
            label11.Text = matrizCompuertaAND[2, 2].ToString();
            label19.Text = fp3.ToString();

            label16.Text = matrizCompuertaAND[3, 0].ToString();
            label15.Text = matrizCompuertaAND[3, 1].ToString();
            label14.Text = matrizCompuertaAND[3, 2].ToString();
            label20.Text = fp4.ToString();

            TBW1Final.Text = ehiiiiiii.w1.ToString();
            TBW2Final.Text = ehiiiiiii.w2.ToString();
            TBBiasFinal.Text = ehiiiiiii.bias.ToString();
            //i1,i2,t



            /*npi=i1*w1+i2*w2+bias
                fpi==T1
                fp1=/=t1
                E=t1-fp1
                nuevoW1=viejoW1+E(i1)
                bias = viejoBias + E;*/
        }
    }
}
