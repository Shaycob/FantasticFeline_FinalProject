using System;
using System.Collections.Generic;
using System.Web.UI;
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
    public partial class Problem3 : System.Web.UI.Page
    {
        private const string CorrectSolution = @"
    public int totalNQueens(int n) {
        List<List<string>> results = new List<List<string>>();
        SolveNQueens(n, 0, new int[n], results);
        return results.Count;
    }

    private void SolveNQueens(int n, int row, int[] board, List<List<string>> results) {
        if (row == n) {
            results.Add(GenerateBoard(board, n));
            return;
        }

        for (int col = 0; col < n; col++) {
            if (IsSafe(board, row, col)) {
                board[row] = col;
                SolveNQueens(n, row + 1, board, results);
                board[row] = -1; // Backtrack
            }
        }
    }

    private bool IsSafe(int[] board, int row, int col) {
        for (int i = 0; i < row; i++) {
            if (board[i] == col || Math.Abs(board[i] - col) == Math.Abs(i - row)) {
                return false;
            }
        }
        return true;
    }

    private List<string> GenerateBoard(int[] board, int n) {
        List<string> result = new List<string>();
        for (int i = 0; i < n; i++) {
            char[] row = new string('.', n).ToCharArray();
            row[board[i]] = 'Q';
            result.Add(new string(row));
        }
        return result;
    }";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NQueensSection.Visible = false; // Ensure hidden on first load
            }
        }

        protected void CheckCodeButton_Click(object sender, EventArgs e)
        {
            string userCode = Server.HtmlDecode(UserCodeTextBox.Text.Trim());

            if (string.IsNullOrEmpty(userCode))
            {
                CodeCheckLiteral.Text = "<span style='color: red;'>Please write your solution.</span>";
                return;
            }

            if (NormalizeSolution(userCode).Equals(NormalizeSolution(CorrectSolution), StringComparison.OrdinalIgnoreCase))
            {
                CodeCheckLiteral.Text = "<span style='color: green;'>Correct! Now, enter a value for N below.</span>";
                NQueensSection.Visible = true; // Make N-Queens input section visible
            }
            else
            {
                CodeCheckLiteral.Text = "<span style='color: red;'>Incorrect Solution. Try again.</span>";
                NQueensSection.Visible = false; // Ensure it stays hidden if solution is incorrect
            }
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string nInput = NInputTextBox.Text.Trim();
            int n;

            if (int.TryParse(nInput, out n) && n >= 1 && n <= 9)
            {
                int result = SolveNQueens(n);
                SolutionResultLiteral.Text = $"<span style='color: green;'>Number of solutions for N = {n}: {result}</span>";
            }
            else
            {
                SolutionResultLiteral.Text = "<span style='color: red;'>Please enter a valid number between 1 and 9.</span>";
            }
        }

        private int SolveNQueens(int n)
        {
            List<List<string>> results = new List<List<string>>();
            SolveNQueensHelper(n, 0, new int[n], results);
            return results.Count;
        }

        private void SolveNQueensHelper(int n, int row, int[] board, List<List<string>> results)
        {
            if (row == n)
            {
                results.Add(GenerateBoard(board, n));
                return;
            }

            for (int col = 0; col < n; col++)
            {
                if (IsSafe(board, row, col))
                {
                    board[row] = col;
                    SolveNQueensHelper(n, row + 1, board, results);
                    board[row] = -1; // Backtrack
                }
            }
        }

        private bool IsSafe(int[] board, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                if (board[i] == col || Math.Abs(board[i] - col) == Math.Abs(i - row))
                {
                    return false;
                }
            }
            return true;
        }

        private List<string> GenerateBoard(int[] board, int n)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < n; i++)
            {
                char[] row = new string('.', n).ToCharArray();
                row[board[i]] = 'Q';
                result.Add(new string(row));
            }
            return result;
        }

        private string NormalizeSolution(string solution)
        {
            return solution.Replace(" ", "").Replace("\t", "").Replace("\r", "").Replace("\n", "");
        }
    }
}
