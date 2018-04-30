using System;
using System.Windows.Forms;

/*
 * by Mark Hawes
 * week 6
 * ChatAWhileGUI takes in user given area code and call length to
 * calculate the cost of a call.
 */


    /*
     * Side Note: I dislike how the sizing works in visual studio.
     * I'd love to have it always auto locate pieces based on the 
     * desired size of the Form box, however, I cannot seem to find
     * anyway to do such a task. If you, the reader of this, have 
     * any reading on this I'd appreciate it greatly. Mhawes90@gmail.com
     */ 


namespace ChatAWhileGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            // create a version of CallCalculator - because it wouldn't
            // let me just allow it to auto return a value...
            CallCalculator calc = new CallCalculator();
            // output box default text
            string outDefault = "Total Cost of Call: ";

            // save callCalc output
            double cost = calc.Calculator(Convert.ToInt32(
                AreaCodeBox.Text), Convert.ToInt32(CallLengthBox.Text));

            // put output label to default + add cost value
            OutputLabel.Text = outDefault + cost.ToString("c");
        }
    }

    // callCalculator class takes in 
    class CallCalculator
    {
        int[] areaCode = {262, 414, 608, 715, 815, 920};
        double[] ratePerMin = {.07, .10, .05, .16, .24, .14};

        public double Calculator(int areaInput, int callLength)
        {
            int index = Array.IndexOf(areaCode, areaInput);
            double callCost = 0;

            // checks that areaInput actually exists in areaCode array
            if (index > -1)
                callCost = callLength * ratePerMin[index];

            return callCost;
        }
    }
}
