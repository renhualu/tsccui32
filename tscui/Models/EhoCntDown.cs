using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tscui.Models
{
    class EhoCntDown
    {
        private byte _ucColor;
        private byte _ucDirec;
        private byte _ucType;
        private ushort _ucFigure;

        public byte Color
        {
            get { return _ucColor; }
            set { _ucColor = value; }
        }
        public byte Direc
        {
            get { return _ucDirec; }
            set { _ucDirec = value; }
        }
        public byte Type
        {
            get { return _ucType; }
            set { _ucType = value; }
        }
        public ushort usFigure
        {
            get { return _ucFigure; }
            set { _ucFigure = value; }
        }
      

    }
    class EchoCntDowns
    {
        public static List<EhoCntDown> _listEhoCntDown;
        public List<EhoCntDown> ListEhoCntDown
        {
            get { return _listEhoCntDown; }
            set { _listEhoCntDown = value; }
        }
    }
}
