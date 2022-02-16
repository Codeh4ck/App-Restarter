using System.Windows.Forms;

namespace AppRestarter.Forms.Controls
{
    public class NumericUpDownEx : NumericUpDown
    {
        // Overriding default NumericUpDown control OnMouseWheel
        // event to handle cases where a single mouse scroll will
        // scroll more than 1 line. This will correctly update 
        // the NumericUpDown value as if the mouse wheel scrolled 1 line.
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (e is HandledMouseEventArgs hme)
                hme.Handled = true;

            if (e.Delta > 0 && (Value + Increment) <= Maximum)
                Value += Increment;
            else if (e.Delta > 0 && (Value + Increment) >= Maximum)
                Value = Maximum;
            else if (e.Delta < 0 && (Value - Increment) >= Minimum)
                Value -= Increment;
            else if (e.Delta < 0 && (Value - Increment) <= Minimum)
                Value = Minimum;
        }
    }
}
