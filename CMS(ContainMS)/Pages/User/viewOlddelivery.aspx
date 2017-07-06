<%@ Page Title="View Delivery" Language="C#" MasterPageFile="~/Pages/User/Site.Master" AutoEventWireup="true" CodeBehind="viewOlddelivery.aspx.cs" Inherits="CMS_ContainMS_.Pages.User.viewOlddelivery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <style>
.mydatagrid

{

    width: 80%;

    border: solid 2px black;

    min-width: 80%;

}

.header

{

    background-color: #646464;

    font-family: Arial;

    color: White;

    border: none 0px transparent;

    height: 25px;

    text-align: center;

    font-size: 16px;

}



.rows

{

    background-color: #fff;

    font-family: Arial;

    font-size: 14px;

    color: #000;

    min-height: 25px;

    text-align: left;

    border: none 0px transparent;

}

.rows:hover

{

    background-color: #80aaff;

    font-family: Arial;

    color: #fff;

    text-align: left;

}

.selectedrow

{

    background-color: #80aaff;

    font-family: Arial;

    color: #cceeff;

    font-weight: bold;

    text-align: left;

}

.mydatagrid a /** FOR THE PAGING ICONS  **/

{

    background-color: Transparent;

    padding: 5px 5px 5px 5px;

    color: #fff;

    text-decoration: none;

    font-weight: bold;

}

 

.mydatagrid a:hover /** FOR THE PAGING ICONS  HOVER STYLES**/

{

    background-color: #000;

    color: #cceeff;

}

.mydatagrid span /** FOR THE PAGING ICONS CURRENT PAGE INDICATOR **/

{

    background-color: #c9c9c9;

    color: #000;

    padding: 5px 5px 5px 5px;

}

.pager

{

    background-color: #646464;

    font-family: Arial;

    color: White;

    height: 30px;

    text-align: left;

}

.mydatagrid td

{

    padding: 5px;

}

.mydatagrid th

{

    padding: 5px;

}

</style>
     <div  class="col-md-3" >
                         </div>
    <div id="myDiv" runat="server" class="col-md-3">
   
    <asp:GridView AutoGenerateColumns="false" Width="900px" ID="viewdeliverytbl" runat="server" CssClass="mydatagrid" PagerStyle-CssClass="pager"
 HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AllowPaging="True">
        <Columns>
                        <asp:BoundField DataField="Package_id" HeaderText="Package ID" />  
                        <asp:BoundField DataField="SenderName" HeaderText="Sender Name" />  
                        <asp:BoundField DataField="RecieverName" HeaderText="Reciever Name" />  
                        <asp:BoundField DataField="Package_Price" HeaderText="Package Price" />
                        <asp:BoundField DataField="Datesent" HeaderText="Date Sent" />
                        <asp:BoundField DataField="Daterecieved" HeaderText="Date Recieved" />
                        <asp:BoundField DataField="status" HeaderText="Status" />
                      

        </Columns> 
    </asp:GridView>
        </div>
</asp:Content>
