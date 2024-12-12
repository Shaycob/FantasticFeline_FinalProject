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
    public partial class Problem4 : Page
    {
        private const string CorrectSolution = @"
public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
    HashSet<string> wordSet = new HashSet<string>(wordList);
    if (!wordSet.Contains(endWord)) return 0;

    Queue<string> queue = new Queue<string>();
    queue.Enqueue(beginWord);
    int steps = 1;

    while (queue.Count > 0) {
        int levelSize = queue.Count;
        for (int i = 0; i < levelSize; i++) {
            string currentWord = queue.Dequeue();
            char[] wordChars = currentWord.ToCharArray();
            for (int j = 0; j < wordChars.Length; j++) {
                char originalChar = wordChars[j];
                for (char c = 'a'; c <= 'z'; c++) {
                    wordChars[j] = c;
                    string transformedWord = new string(wordChars);
                    if (transformedWord == endWord) return steps + 1;
                    if (wordSet.Contains(transformedWord)) {
                        queue.Enqueue(transformedWord);
                        wordSet.Remove(transformedWord);
                    }
                }
                wordChars[j] = originalChar;
            }
        }
        steps++;
    }
    return 0;
}";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TransformationSection.Attributes["style"] = "visibility: hidden;";
                CodeCheckLiteral.Text = "";
                TransformationResultLiteral.Text = "";
            }
        }

        protected void CheckCodeButton_Click(object sender, EventArgs e)
        {
            string userCode = UserCodeTextBox.Text.Trim();

            if (string.IsNullOrEmpty(userCode))
            {
                CodeCheckLiteral.Text = "<span style='color: red;'>Please write your solution.</span>";
                return;
            }

            if (NormalizeSolution(userCode).Equals(NormalizeSolution(CorrectSolution), StringComparison.OrdinalIgnoreCase))
            {
                CodeCheckLiteral.Text = "<span style='color: green;'>Correct! The Word Transformation section is now unlocked.</span>";
                TransformationSection.Attributes["style"] = "visibility: visible;";
            }
            else
            {
                CodeCheckLiteral.Text = "<span style='color: red;'>Incorrect Solution. Try again.</span>";
            }
        }

        protected void RunButton_Click(object sender, EventArgs e)
        {
            string transformationDetails = TransformationExpressionTextBox.Text.Trim();

            if (string.IsNullOrEmpty(transformationDetails))
            {
                TransformationResultLiteral.Text = "<span style='color: red;'>Please enter valid transformation details.</span>";
                return;
            }

            // Simulated output
            TransformationResultLiteral.Text = $"<span style='color: green;'>Transformation successful: {transformationDetails}</span>";
        }

        private string NormalizeSolution(string solution)
        {
            return solution.Replace(" ", "").Replace("\t", "").Replace("\r", "").Replace("\n", "");
        }
    }
}
