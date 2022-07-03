<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BMI_Web_Form._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Unit 6 SOC Project</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Height:
                <asp:TextBox ID="height" runat="server"></asp:TextBox>
            </h2>
            <h2>Weight:
                <asp:TextBox ID="weight" runat="server"></asp:TextBox>
            </h2>
            <h2>SOAP Service Call:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; BMI:&nbsp;<asp:Label ID="soapBMILabel" runat="server" Text=""></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Health Indicator:
                <asp:Label ID="soapHealthIndicatorLabel" runat="server" Text=""></asp:Label>
            </h2>
            <p>
                <asp:Button ID="soapBMIButton" runat="server" Height="46px" OnClick="soapBMIButton_Click" Text="Call SOAP API" Width="189px" />
            </p>
            <h2>REST Service:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; BMI:
                <asp:Label ID="bmiRestLabel" runat="server" Text=""></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Health Indicator:
                <asp:Label ID="healthIndicatorRestLabel" runat="server" Text=""></asp:Label>
            </h2>
            <p>
                <asp:Button ID="restBMIButton" runat="server" Text="Call REST API" Height="45px" Width="176px" OnClick="restBMIButton_Click" />
            </p>
        </div>
        <div class="col-md-4">
        </div>
        <div class="col-md-4">

            <p>
                &nbsp;
            </p>
        </div>
    </div>

</asp:Content>
