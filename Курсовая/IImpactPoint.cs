using System;
using System.Drawing;

namespace Курсовая
{
    public abstract class IImpactPoint
    {
        public float X; 
        public float Y;

        public abstract void ImpactParticle(Particle particle);

        public virtual void Render(Graphics g)
        {
            g.FillEllipse(
                    new SolidBrush(Color.Red),
                    X - 5,
                    Y - 5,
                    10,
                    10
                );
        }
    }
    public class CountPoint : IImpactPoint
    {
        public int Power = 100;
        public int count = 0;
        public override void ImpactParticle(Particle particle)
        {
            if (count < 15000)
            {
                float gX = X - particle.X;
                float gY = Y - particle.Y;

                double r = Math.Sqrt(gX * gX + gY * gY);
                //Если частица внутри точки
                if (r + particle.Radius < Power / 1.7 && particle.Life > 0)
                {
                    //Убить частицу
                    particle.Life = 0;
                    //Увеличить кол-во на 1
                    count++;
                }
            }
            else
            {
                count = 0;
            }
        }

        public override void Render(Graphics g)
        {
            var color = Color.FromArgb(count / 60, Color.Red);
            //Нарисовать точку
            g.FillEllipse(
                   new SolidBrush(color),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
               );
            g.DrawEllipse(
                new Pen(Color.Red, 3),
                 X - Power / 2,
                 Y - Power / 2,
                   Power,
                   Power
                );
            //Вывести информацию
            var stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            g.DrawString(
                count.ToString(),
                new Font("Verdana", 10),
            new SolidBrush(Color.White),
            X,
            Y,
            stringFormat
                );
        }
    }

    public class ColorPoint : IImpactPoint
    {
        public int Power = 100;
        public Color color;
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY);
            //Если частица внутри точки
            if (r + particle.Radius < Power / 1.7 && particle.Life > 0)
            {
                //Перекрасить частицу
                (particle as ParticleColorful).FromColor = color;
            }
        }

        public override void Render(Graphics g)
        {
            //Нарисовать точку
            g.DrawEllipse(
                   new Pen(color, 3),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
               );
        }
    }

  

}



