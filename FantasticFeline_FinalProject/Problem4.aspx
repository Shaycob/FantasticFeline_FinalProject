<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Problem4.aspx.cs" Inherits="FantasticFeline_FinalProject.Problem4" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Word Ladder Problem</title>
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
        .description, .code-input, .transformation {
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
        .transformation {
            display: block;
        }
    </style>
</head>
<body>
<form id="form1" runat="server">
    <div class="container">
        <!-- Problem Description Section -->
        <div class="description">
            <h1>Word Ladder Problem</h1>
            <p>
                A transformation sequence from word <code>beginWord</code> to word
                <code>endWord</code> using a dictionary <code>wordList</code> is a sequence of words:
                <code>beginWord -> s1 -> s2 -> ... -> sk</code>, such that:
            </p>
            <ul>
                <li>Every adjacent pair of words differs by a single letter.</li>
                <li>Every <code>si</code> for 1 <= i <= k is in <code>wordList</code>. Note that
                    <code>beginWord</code> does not need to be in <code>wordList</code>.</li>
                <li><code>sk == endWord</code>.</li>
            </ul>
            <p>
                Given two words, <code>beginWord</code> and <code>endWord</code>, and a
                dictionary <code>wordList</code>, return the number of words in the shortest transformation
                sequence from <code>beginWord</code> to <code>endWord</code>, or <code>0</code> if no
                such sequence exists.
            </p>
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
        <!-- Word Transformation Section -->
        <div id="TransformationSection" runat="server" class="transformation" style="visibility: hidden;">
            <h2>Word Transformation</h2>
            <asp:TextBox ID="TransformationExpressionTextBox" runat="server" CssClass="textbox" Placeholder="Enter transformation details..."></asp:TextBox>
            <asp:Button ID="RunButton" runat="server" Text="Run" CssClass="button" OnClick="RunButton_Click" />
            <div class="output">
                <asp:Literal ID="TransformationResultLiteral" runat="server"></asp:Literal>
            </div>
        </div>
    </div>
</form>
</body>
</html>
