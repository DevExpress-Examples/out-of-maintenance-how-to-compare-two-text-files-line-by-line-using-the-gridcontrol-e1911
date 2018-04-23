using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public class LineClass
    {

        private string _FirstFileLine;
        public string FirstFileLine
        {
            get { return _FirstFileLine; }
            set { _FirstFileLine = value; }
        }

        private string _SecondFileLine;
        public string SecondFileLine
        {
            get { return _SecondFileLine; }
            set { _SecondFileLine = value; }
        }
        public LineClass(string f, string s)
        {
            FirstFileLine = f;
            SecondFileLine = s;
        }
    }
}
