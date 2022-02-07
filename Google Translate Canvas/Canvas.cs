using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Google_Translate_Canvas
{
    public partial class Canvas : UserControl
    {
        public Canvas()
        {
            InitializeComponent();
        }

        Graphics canvasGraphics;
        Pen canvasPen;
        int previousX;
        int previousY;
        bool draw;

        private void Canvas_Load(object sender, EventArgs e)
        {
            draw = false;
            canvasGraphics = CreateGraphics();
            canvasPen = new Pen(Color.Black, 7);
        }
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            //When the user starts drawing a new line, create a new
            //instance of a line object to add coordinates to
            Program.form1.addLine();

            draw = true;
            previousX = e.X;
            previousY = e.Y;
        }
        private async void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;

            //Once the user has finished drawing a line, send a post request to inputtools
            await Task.Run(() => Program.form1.googleRequest());
        }
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw == false || (Math.Abs(e.X - previousX) <= 5 && Math.Abs(e.Y - previousY) <= 5))
            {
                return;
            }

            if (e.X > previousX) { previousX += -1; }
            else if (e.X < previousX) { previousX += 1; }
            if (e.Y > previousY) { previousY += -1; }
            else if (e.Y < previousY) { previousY += 1; }

            //add coordinates to the latest instance of line object
            Program.form1.addXCoordinate(e.X);
            Program.form1.addYCoordinate(e.Y);

            //draw a line from the last mouse position to the new mouse position
            canvasGraphics.DrawLine(canvasPen, previousX, previousY, e.X, e.Y);

            previousX = e.X;
            previousY = e.Y;
        }
        private void Canvas_FormClosed(object sender, FormClosedEventArgs e)
        {
            canvasGraphics.Dispose();
            canvasPen.Dispose();
        }
        public void clearCanvas()
        {
            canvasGraphics.Clear(Color.FromArgb(222, 222, 222));
        }
        private void Canvas_Resize(object sender, EventArgs e)
        {
            canvasGraphics = CreateGraphics();
        }
    }
}
