<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Problem3.aspx.cs" Inherits="FantasticFeline_FinalProject.Problem3" %>
<!--
* Name: Jacob Farrell, Chase Detrick, Matthew Boutros, Andrew Rozsits
* email:  farrelcj@mail.uc.edu, detriccg@mail.uc.edu, boutromw@mail.uc.edu, rozsitaj@mail.uc.edu
* Assignment Number: Assignment 11/ Final Project
* Due Date:   12/12/2024
* Course #/Section:   IS3050 (002)
* Semester/Year:   Fall 2024
* Brief Description of the assignment:  This is our final project for IS3050, in this project we recreated the website LeetCode. Each member of our team solved and created code from the hard section 
                                        of LeetCode. Utilizing github we created a our own version of LeetCode.
* Brief Description of what this module does. This module demonstrates our ability to collaboratively work on creating a functional website.
* Citations: chatgpt.com, stackoverflow.com
* Anything else that's relevant:
-->
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>N-Queens II Problem</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #121212;
            color: white;
            margin: 0;
            padding: 20px;
        }

        .container {
            display: flex;
            flex-direction: column;
            gap: 20px;
        }

        .description, .code-input, .n-queens {
            background-color: #1c1c1c;
            padding: 20px;
            border-radius: 10px;
        }

        .textbox {
            width: 100%;
            height: 150px;
            font-family: Consolas, monospace;
            font-size: 14px;
            background-color: #333;
            color: white;
            border: 1px solid #555;
            border-radius: 5px;
            padding: 10px;
        }

        .button {
            background-color: #61dafb;
            color: #121212;
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            font-size: 16px;
            cursor: pointer;
        }

        .button:hover {
            background-color: #4aa3d8;
        }

        .output {
            margin-top: 10px;
            font-size: 18px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <!-- Problem Description Section -->
            <div class="description">
                <h1>N-Queens II</h1>
                <p>
                    The n-queens puzzle is the problem of placing n queens on an n x n chessboard such that no two queens attack each other.
                    Given an integer n, return the number of distinct solutions to the n-queens puzzle.
                </p>
                <h2>Examples</h2>
                <pre>
Example 1:
Input: n = 4
Output: 2
Explanation: There are two distinct solutions to the 4-queens puzzle.

Example 2:
Input: n = 1
Output: 1
                </pre>
                <h2>Constraints</h2>
                <ul>
                    <li>1 <= n <= 9</li>
                </ul>
            </div>

            <!-- Code Input Section -->
            <div class="code-input">
                <h2>Write Your Code Solution</h2>
                <asp:TextBox ID="UserCodeTextBox" runat="server" TextMode="MultiLine" CssClass="textbox" Placeholder="Write your solution here..."></asp:TextBox>
                <asp:Button ID="CheckCodeButton" runat="server" Text="Check Solution" CssClass="button" OnClick="CheckCodeButton_Click" />
                <div class="output">
                    <asp:Literal ID="CodeCheckLiteral" runat="server"></asp:Literal>
                </div>
            </div>

            <!-- N-Queens Input Section -->
            <div id="NQueensSection" runat="server" visible="false">
                <h2>Enter Value of N</h2>
                <asp:TextBox ID="NInputTextBox" runat="server" CssClass="textbox" Placeholder="Enter the value of N (1 <= n <= 9)" />
                <asp:Button ID="SubmitButton" runat="server" Text="Get Solutions" CssClass="button" OnClick="SubmitButton_Click" />
                <div class="output">
                    <asp:Literal ID="SolutionResultLiteral" runat="server"></asp:Literal>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
