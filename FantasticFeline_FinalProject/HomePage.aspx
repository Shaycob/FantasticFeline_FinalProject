<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="FantasticFeline_FinalProject.WebForm1" %>
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
    <title>LeetCode Homepage</title>
    <style>
        /* General Page Styling */
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #121212;
            color: #ffffff;
        }
        .container {
            display: flex;
            flex-direction: row;
            margin: 20px;
        }
        .sidebar {
            width: 20%;
            background-color: #1c1c1c;
            padding: 10px;
            margin-right: 10px;
            border-radius: 8px;
        }
        .main-content {
            flex: 1;
            background-color: #1c1c1c;
            padding: 10px;
            border-radius: 8px;
        }
        table {
            width: 100%;
            border-collapse: collapse;
            margin: 20px 0;
        }
        th, td {
            padding: 12px;
            text-align: left;
            border-bottom: 1px solid #333;
        }
        th {
            background-color: #2a2a2a;
        }
        .companies {
            background-color: #1c1c1c;
            padding: 10px;
            margin-left: 10px;
            border-radius: 8px;
        }
        .calendar-day {
            color: white;
        }
        .company-button {
            background-color: #2a2a2a;
            color: white;
            border: 1px solid #444;
            padding: 10px 15px;
            margin: 5px 0;
            border-radius: 5px;
            font-size: 16px;
            cursor: pointer;
            width: 100%;
            text-align: left;
        }
        .company-button:hover {
            background-color: #444;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="sidebar">
                <h3>Calendar</h3>
                <asp:Calendar ID="CalendarControl" runat="server" OnDayRender="CalendarControl_DayRender" />
            </div>
            <div class="main-content">
                <h2>Problem List</h2>
                <table>
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Title</th>
                            <th>Difficulty</th>
                            <th>Acceptance</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>1</td>
                            <td><a href="Problem1.aspx">Basic Calculator</a></td>
                            <td>Hard</td>
                            <td>58%</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td><a href="Problem2.aspx">Shortest Impossible Sequence of Rolls</a></td>
                            <td>Hard</td>
                            <td>39%</td>
                        </tr>
                        <tr>
                            <td>3</td>
                            <td><a href="Problem3.aspx">N-Queens II Problem</a></td>
                            <td>Hard</td>
                            <td>47%</td>
                        </tr>
                        <tr>
                            <td>4</td>
                            <td><a href="Problem4.aspx">Word Ladder Problem</a></td>
                            <td>Hard</td>
                            <td>34%</td>
                        </tr>
                    </tbody>
                </table>
            </div>
            <div class="companies">
                <h3>Trending Companies</h3>
                <ul>
                    <li><asp:Button ID="GoogleButton" runat="server" Text="Google" OnClick="RedirectToGoogle" CssClass="company-button" /></li>
                    <li><asp:Button ID="MetaButton" runat="server" Text="Meta" OnClick="RedirectToMeta" CssClass="company-button" /></li>
                    <li><asp:Button ID="OracleButton" runat="server" Text="Oracle" OnClick="RedirectToOracle" CssClass="company-button" /></li>
                    <li><asp:Button ID="MicrosoftButton" runat="server" Text="Microsoft" OnClick="RedirectToMicrosoft" CssClass="company-button" /></li>
                    <li><asp:Button ID="NvidiaButton" runat="server" Text="Nvidia" OnClick="RedirectToNvidia" CssClass="company-button" /></li>
                    <li><asp:Button ID="PayPalButton" runat="server" Text="PayPal" OnClick="RedirectToPayPal" CssClass="company-button" /></li>
                </ul>
            </div>
        </div>
    </form>
</body>
</html>
