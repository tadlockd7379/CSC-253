/**
* 9/14/2023
* CSC 253
* Drew Tadlock
* Let user select course number and list info about it
*/


using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace M1HW1_Tadlock_Resubmit
{
    public partial class Form1 : Form
    {
        static Dictionary<string, int> courses = new Dictionary<string, int>()
        {
            { "CS101", 3004 },
            { "CS102", 4501 },
            { "CS103", 6755 },
            { "NT110", 1244 },
            { "CM241", 1411 }
        };

        static Dictionary<string, string> instructors = new Dictionary<string, string>()
        {
            { "CS101", "Haynes" },
            { "CS102", "Alvarado" },
            { "CS103", "Rich" },
            { "NT110", "Burke" },
            { "CM241", "Lee" }
        };

        Dictionary<string, string> times = new Dictionary<string, string>()
        {
            { "CS101", "8:00 AM" },
            { "CS102", "9:00 AM" },
            { "CS103", "10:00 AM" },
            { "NT110", "11:00 AM" },
            { "CM241", "1:00 PM" }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateResult(string course)
        {
            resultLabel.Text = $"{course} is held at room {courses[course]} at {times[course]} and taught by Prof. {instructors[course]}.";
        }

        private void cs101_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateResult("CS101");
        }

        private void cs102_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateResult("CS102");
        }

        private void cs103_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateResult("CS103");
        }

        private void nti110_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateResult("NT110");
        }

        private void cm241_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateResult("CM241");
        }
    }
}
