<%@ Page Title="Regions" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Regions.aspx.cs" Inherits="WebApplication3.Regions" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application regions page.</h3>
    <p>Use this area to provide additional information about region.</p>
<p>&nbsp;</p>
<p>
        <asp:Label ID="Label5" runat="server" Text="Region ID"></asp:Label>
        <asp:TextBox ID="tjobid0" runat="server" ></asp:TextBox>
        </br>
        <asp:Label ID="Label6" runat="server" Text="Region name"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></p>
    <p>
        &nbsp;</p>
<p>
    <asp:Button ID="Button1" runat="server" Text="Save"  />
    <asp:Button ID="Button2" runat="server" Text="Close" />
</p>
<p>&nbsp;</p>
<p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="REGION_ID" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="REGION_ID" HeaderText="REGION_ID" ReadOnly="True" SortExpression="REGION_ID" />
            <asp:BoundField DataField="REGION_NAME" HeaderText="REGION_NAME" SortExpression="REGION_NAME" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString7 %>" ProviderName="<%$ ConnectionStrings:ConnectionString7.ProviderName %>" SelectCommand="SELECT REGION_ID, REGION_NAME FROM REGIONS"></asp:SqlDataSource>
    </br>
        </p>
</asp:Content>
 