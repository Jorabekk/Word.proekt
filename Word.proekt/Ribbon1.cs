﻿using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using word = Microsoft.Office.Interop.Word;

namespace Word.proekt
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }
        
        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
           // word.Selection select = word.; ;
        }
    }
}
