

using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using TUIO;


public class TuioDemoObject : TuioObject 
{

	SolidBrush black = new SolidBrush(Color.Black);
	SolidBrush white = new SolidBrush(Color.White);

	//Bitmap myimg1 = new Bitmap("1.bmp");
	//Bitmap myimg2 = new Bitmap("2.bmp");

	public TuioDemoObject (long s_id, int f_id, float xpos, float ypos, float angle, int v) : base(s_id,f_id,xpos,ypos,angle) 
	{
	}

	public TuioDemoObject (TuioObject o) : base(o) 
	{
	}
	
	public void paint(Graphics g) {
		
	    int Xpos = (int)(xpos*TuioDemo.width);
		int Ypos = (int)(ypos*TuioDemo.height);
		int size = TuioDemo.height/10;


		g.TranslateTransform(Xpos,Ypos);
		g.RotateTransform((float)(angle/Math.PI*180.0f));
		g.TranslateTransform(-1*Xpos,-1*Ypos);

		//if (symbol_id == 1){ g.DrawImage(myimg1, Xpos - size / 2, Ypos - size / 2); }
		//if (symbol_id == 1) { g.DrawImage(myimg2, Xpos - size / 2, Ypos - size / 2); }
		
		g.TranslateTransform(Xpos,Ypos);
		g.RotateTransform(-1*(float)(angle/Math.PI*180.0f));
		g.TranslateTransform(-1*Xpos,-1*Ypos);

		//Font font = new Font("Arial", 10.0f);
		//g.DrawString(symbol_id+"",font, white, new PointF(Xpos-10,Ypos-10));
	}

}
