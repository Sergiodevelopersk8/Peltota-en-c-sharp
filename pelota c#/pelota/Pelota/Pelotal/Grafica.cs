using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Pelotal
{
    public class Grafica
    {
        private Graphics Lienzo;
        private int xi = 0, yi = 0;

        public Grafica (PictureBox pb)
        {
            pb.BorderStyle = BorderStyle.FixedSingle;
            pb.BackColor = Color.Brown;
            Lienzo = pb.CreateGraphics();
            xi = pb.Width / 2;
            yi = pb.Height / 2;
        }



        public void Animacion(PictureBox pb, int direc, string color)
        {

            SolidBrush pen1 = new SolidBrush(Color.Brown);
            SolidBrush pen2 = new SolidBrush(Color.Blue);
            switch (color)
            {
                case "Azul":
                    pen2= new SolidBrush(Color.Blue);
                    break;
                case "Rojo":
                    pen2 = new SolidBrush(Color.Red);
                    break;
                case "Verde":
                    pen2 = new SolidBrush(Color.Green);
                    break;
                case "Negro":
                    pen2 = new SolidBrush(Color.Black);
                    break;
                case "Rosa":
                    pen2 = new SolidBrush(Color.Pink);
                    break;
                case "Morado":
                    pen2 = new SolidBrush(Color.Purple);
                    break;
            }
           
            int xi, yi;
            int lonx, lony;
            int c, incre;

        
            
            xi = pb.Width / 2;
            yi = pb.Height / 2;
            int radio = 35;
            int velocix = 2;
            int velociy = 2;
            incre = 5;
            /*Random alaza = new Random();
            int alazar;
            alazar = alaza.Next(1, 5);*/


            int colicion = 0;

            if (direc == 1)
            {
                int direccionx = 3;
                int direcciony = 3;

                do
                {
                    Lienzo.FillEllipse(pen2, new Rectangle(xi - radio, yi - radio, radio * 2, radio * 2));
                    PerderTiempo();
                    Lienzo.FillEllipse(pen1, new Rectangle(xi - radio, yi - radio, radio * 2, radio * 2));
                    if (xi > pb.Width - radio || xi < radio)
                    {
                        direccionx = -direccionx;
                        colicion++;
                    }

                    if (yi > pb.Height - radio || yi < radio)
                    {
                        direcciony = -direcciony;
                        colicion++;
                    }

                    xi += velocix * direccionx;
                    yi += velociy * direcciony;


                } while (colicion != 4);
            }
           else if (direc == 2) 
            {
                int direccionxx = -3;
               int direccionyy = 3;
                do
                {
                    Lienzo.FillEllipse(pen2, new Rectangle(xi - radio, yi - radio, radio * 2, radio * 2));
                    PerderTiempo();
                    Lienzo.FillEllipse(pen1, new Rectangle(xi - radio, yi - radio, radio * 2, radio * 2));
                    if (xi > pb.Width - radio || xi < radio)
                    {
                        direccionxx = -direccionxx;
                        colicion++;
                    }
                    if (yi > pb.Height - radio || yi < radio)
                    {
                        direccionyy = -direccionyy;
                        colicion++;
                    }


                    xi += velocix * direccionxx;
                    yi += velociy * direccionyy;
                } while (colicion != 4);

            }
           else  if (direc == 3)
            {
               int direccionxxx = -3;
                int direccionyyy = -3;
                do
                {
                    Lienzo.FillEllipse(pen2, new Rectangle(xi - radio, yi - radio, radio * 2, radio * 2));
                    PerderTiempo();
                    Lienzo.FillEllipse(pen1, new Rectangle(xi - radio, yi - radio, radio * 2, radio * 2));
                    if (xi < radio || xi >pb.Width-radio)
                    {
                        direccionxxx = -direccionxxx;
                        colicion++;
                    }
                    if (yi > pb.Height - radio || yi < radio)
                    {
                        direccionyyy = -direccionyyy;
                        colicion++;
                    }


                    xi += velocix * direccionxxx;
                    yi += velociy * direccionyyy;


                } while (colicion != 4) ;
            }

           else if (direc == 4)  
            {
                int direccionxxxx = 3;
                int direccionyyyy = -3;
                do
                {
                    Lienzo.FillEllipse(pen2, new Rectangle(xi - radio, yi - radio, radio * 2, radio * 2));
                    PerderTiempo();
                    Lienzo.FillEllipse(pen1, new Rectangle(xi - radio, yi - radio, radio * 2, radio * 2));
                    if (xi > pb.Width - radio || xi < radio)
                    {
                        direccionxxxx = -direccionxxxx;
                        colicion++;
                    }
                    if (yi > pb.Height - radio || yi < radio)
                    {
                        direccionyyyy = -direccionyyyy;
                        colicion++;
                    }


                    xi += velocix * direccionxxxx;
                    yi += velociy * direccionyyyy;
                } while (colicion != 4);

            } 
        }

        private void PerderTiempo()
        {
            int a;
            int b;
            for (b = 1; b < 100000; b++)
            {
                for (a = 0; a < 200; a++)
                {

                }
            }
        }

    }
}
