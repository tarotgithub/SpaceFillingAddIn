using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Forms = System.Windows.Forms;

namespace SpaceFillingAddIn
{
    public partial class SpaceFillingRibbon
    {
        private int textLength = 0;

        private static int GetLength(String s, int nonAsciiLength)
        {
            int length = 0;
            if(s != null)
            {
                foreach (char c in s)
                {
                    length += c <= 127 ? 1 : nonAsciiLength;
                }
            }
            return length;
        }

        private void SpaceFillingRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void buttonRecorder_Click(object sender, RibbonControlEventArgs e)
        {
            Application wordApp = Globals.ThisAddIn.Application;
            Document activeDoc = wordApp.ActiveDocument;
            Range selectedRange = wordApp.Selection.Range;

            textLength = GetLength(selectedRange.Text, 2);
            this.labelLength.Label = (String)this.labelLength.Tag + textLength;
        }

        private void buttonFiller_Click(object sender, RibbonControlEventArgs e)
        {
            Application wordApp = Globals.ThisAddIn.Application;
            Document activeDoc = wordApp.ActiveDocument;
            Range selectedRange = wordApp.Selection.Range;

            int insertLength = textLength - GetLength(selectedRange.Text, 2);
            insertLength = Math.Max(insertLength, 0);
            String textBefore = new String(' ', insertLength / 2);
            String textAfter = new String(' ', (insertLength + 1) / 2);

            selectedRange.InsertBefore(textBefore);
            selectedRange.InsertAfter(textAfter);
            selectedRange.Select();
        }
    }
}
