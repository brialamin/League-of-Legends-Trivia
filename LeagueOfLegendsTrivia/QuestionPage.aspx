<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuestionPage.aspx.cs" Inherits="LeagueOfLegendsTrivia.QuestionPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>League of Legends Trivia!</title>
</head>
<body style ="background-image: url('back.jpg'); background-position:center top;">
<style type="text/css">
     .teambutton
     {
          background-image:url('gold.jpg');
     }
     .visionward
     {
          background-image:url('vw.png');   
     }
     .threesightward
     {
          background-image:url('3sw.png');  
     }
     .twosightward
     {
          background-image:url('2sw.png');
     }
     .onesightward
     {
          background-image:url('sw.png');   
     }
     .steal
     {
          background-image:url('smite.png');  
     }
     .next
     {
          background-image:url('LOL.jpg');   
     }
     
</style>
    <form id="form1" runat="server">
    <div align="center" 
        style="font-family: 'Arial Black'; font-size: xx-large; color: #FFFFFF">
    
        <asp:Label ID="Counter" runat="server" Text="0" Visible="False"></asp:Label>
    
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text=" " CssClass="next" Height="145" 
            Width="348" BorderStyle="None" />
        <br />
        TRIVIA<br />
        <asp:Label ID="Label3" runat="server" Text="Hi"></asp:Label>
        </div>
        <div align="center" 
        style="font-family: Algerian; font-size: large; color: #FFFFFF">
        <asp:Label ID="t1" runat="server" Text="Blue Team" Font-Names="Aharoni" 
                Font-Size="X-Large" ForeColor="#1AA3E3"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:Label ID="t2" runat="server" Text="Purple Team" ForeColor="#981AAF" 
                Font-Names="Aharoni" Font-Size="X-Large"></asp:Label><br />
            <asp:Button ID="Button3" runat="server" Text="       0" CssClass="teambutton" 
                Height="33px" Width="139px" BorderStyle="None" Font-Bold="True" 
                Font-Size="Medium" ForeColor="#F0EAB6" onclick="Button3_Click1" />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Button ID="Button4" runat="server" Text="      0" CssClass="teambutton" 
                BorderStyle="None" Font-Bold="True" Font-Size="Medium" ForeColor="#F0EAB6" 
                Height="33px" Width="139px" onclick="Button4_Click"/>
        <br />
            <asp:Button ID="Button5" runat="server" Text=" " CssCLass="threesightward" 
                BorderStyle="None" Height="47px" Width="47px" Font-Bold="True" 
                ForeColor="White" onclick="Button5_Click"/>
            <asp:Button ID="Button6" runat="server" BorderStyle="None" 
                CssClass="visionward" Height="47px" Text=" " Width="47px" Font-Bold="True" 
                ForeColor="White" onclick="Button6_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button7" runat="server" BorderStyle="None" 
                CssClass="threesightward" Height="47px" Text=" " Width="47px" 
                Font-Bold="True" ForeColor="White" onclick="Button7_Click" />
            <asp:Button ID="Button8" runat="server" BorderStyle="None" 
                CssClass="visionward" Height="47px" Text=" " Width="47px" Font-Bold="True" 
                ForeColor="White" onclick="Button8_Click" />
        <br />
            <asp:Button ID="Button9" runat="server" BorderStyle="None" CssClass="steal" 
                Height="44px" Text=" " Width="45px" onclick="Button9_Click" /> 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Button ID="Button10" runat="server" BorderStyle="None" CssClass="steal" 
                Height="44px" Text=" " Width="45px" onclick="Button10_Click" />
        <br />
        <asp:Button ID="Button2" runat="server" ForeColor="#0000CC" 
            Text="Start Game!" onclientclick="Button2_Click" />
        <br />

    </div>
    </form>
</body>
</html>
