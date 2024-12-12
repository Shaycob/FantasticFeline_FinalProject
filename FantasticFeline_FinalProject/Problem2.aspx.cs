using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// Name: Jacob Farrell, Chase Detrick, Matthew Boutros, Andrew Rozsits
// email:  farrelcj @mail.uc.edu, detriccg @mail.uc.edu, boutromw @mail.uc.edu, rozsitaj @mail.uc.edu
// Assignment Number: Assignment 11/ Final Project
// Due Date:   12 / 12 / 2024
// Course #/Section:   IS3050 (002)
// Semester / Year:   Fall 2024
// Brief Description of the assignment:  This is our final project for IS3050, in this project we recreated the website LeetCode. Each member of our team solved and created code from the hard section 
//                                        of LeetCode. Utilizing github we created a our own version of LeetCode.
// Brief Description of what this module does. This module demonstrates our ability to collaboratively work on creating a functional website.
// Citations: chatgpt.com, stackoverflow.com
// Anything else that's relevant:
namespace FantasticFeline_FinalProject
{
    public partial class Problem2 : System.Web.UI.Page
    {
        private const string CorrectSolution = @"
        public int ShortestImpossibleSequence(int[] rolls, int k)
        {
            int subsequenceCount = 0;
            HashSet<int> seenNumbers = new HashSet<int>();

            foreach (int roll in rolls)
            {
                seenNumbers.Add(roll);

                if (seenNumbers.Count == k)
                {
                    subsequenceCount++;
                    seenNumbers.Clear();
                }
            }

            return subsequenceCount + 1;
        }";

        protected void CheckCodeButton_Click(object sender, EventArgs e)
        {
            string userCode = UserCodeTextBox.Text.Trim();

            if (string.IsNullOrEmpty(userCode))
            {
                CodeCheckLiteral.Text = "<span style='color: red;'>Please write your solution.</span>";
                return;
            }

            if (NormalizeCode(userCode).Equals(NormalizeCode(CorrectSolution), StringComparison.OrdinalIgnoreCase))
            {
                CodeCheckLiteral.Text = "<span style='color: green;'>Correct! You can now test your code with inputs below.</span>";
                CalculatorSection.Style["display"] = "block";
            }
            else
            {
                CodeCheckLiteral.Text = "<span style='color: red;'>Incorrect Solution. Please try again.</span>";
            }
        }

        protected void RunButton_Click(object sender, EventArgs e)
        {
            string rollsInput = RollsInputTextBox.Text.Trim();
            string kInput = KInputTextBox.Text.Trim();

            if (string.IsNullOrEmpty(rollsInput) || string.IsNullOrEmpty(kInput))
            {
                CalculatorResultLiteral.Text = "<span style='color: red;'>Please provide valid input for rolls and k.</span>";
                return;
            }

            try
            {
                int[] rolls = Array.ConvertAll(rollsInput.Split(','), int.Parse);
                int k = int.Parse(kInput);
                int result = ShortestImpossibleSequence(rolls, k);

                CalculatorResultLiteral.Text = $"<span style='color: green;'>Shortest Impossible Sequence Length: {result}</span>";
            }
            catch (Exception ex)
            {
                CalculatorResultLiteral.Text = $"<span style='color: red;'>Error: {ex.Message}</span>";
            }
        }

        private int ShortestImpossibleSequence(int[] rolls, int k)
        {
            int subsequenceCount = 0;
            HashSet<int> seenNumbers = new HashSet<int>();

            foreach (var roll in rolls)
            {
                seenNumbers.Add(roll);

                if (seenNumbers.Count == k)
                {
                    subsequenceCount++;
                    seenNumbers.Clear();
                }
            }

            return subsequenceCount + 1;
        }

        private string NormalizeCode(string code)
        {
            return code.Replace(" ", "").Replace("\t", "").Replace("\r", "").Replace("\n", "");
        }
    }
}
