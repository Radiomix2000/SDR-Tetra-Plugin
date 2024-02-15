﻿using SDRSharp.Common;
using System.Windows.Forms;

namespace SDRSharp.Tetra
{
    public class TetraPlugin : ISharpPlugin
    {
        private const string _displayName = "TETRA Demodulator";
        private ISharpControl _controlInterface;
        private TetraPanel _qpskPanel;

        public UserControl Gui
        {
            get { return _qpskPanel; }
        }

        public string DisplayName
        {
            get { return _displayName; }
        }

        public void Initialize(ISharpControl control)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            _controlInterface = control;
            _qpskPanel = new TetraPanel(_controlInterface);
        }

        public void Close()
        {
            _qpskPanel.SaveSettings();
        }

    }
}
