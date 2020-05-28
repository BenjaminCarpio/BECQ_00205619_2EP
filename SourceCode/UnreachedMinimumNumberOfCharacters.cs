using System;
using System.Windows.Forms;

namespace SourceCode
{
    public class UnreachedMinimumNumberOfCharacters : Exception
    {
        public UnreachedMinimumNumberOfCharacters(string message) : base(message)
        {
            MessageBox.Show(message);
        }
    }
}