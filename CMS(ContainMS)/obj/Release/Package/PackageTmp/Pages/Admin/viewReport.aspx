<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/SiteAdmin.Master" AutoEventWireup="true" CodeBehind="viewReport.aspx.cs" Inherits="CMS_ContainMS_.Pages.Admin.viewReport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script language="javascript" type="text/javascript">
    $(document).ready(function () {
        $("#<%= fromdates.ClientID %>").datepicker({ dateFormat: "yy-mm-dd" }).val();
        $("#<%= todates.ClientID %>").datepicker({ dateFormat: "yy-mm-dd" }).val();
        
    });
</script>
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
   <div class="col-md-1">
       </div>
     <div class="col-md-2">
         <asp:RadioButtonList AutoPostBack="true" ID="Report_radio" runat="server"  OnSelectedIndexChanged="Report_radio_SelectedIndexChanged" >
             
             <asp:ListItem Text="Delivery Group Report" Value="0" />
         </asp:RadioButtonList>
         <br><br>
     <div id="div_email" runat="server" class="form-group"  >
                    <asp:Label ID="lbl_register_email" runat="server">Email: </asp:Label>
                    <asp:RequiredFieldValidator ID="valid_reg_email" runat="server" ControlToValidate="txt_register_email"
                        ErrorMessage="Email is required" ForeColor="Red" ValidationGroup="grp2"></asp:RequiredFieldValidator>

                    <asp:TextBox ID="txt_register_email" runat="server" Width="200px" class="form-control" ValidationGroup="grp2"></asp:TextBox>
                  <br>
                    <asp:Button ID="btn_find_email" runat="server" Text="Find" class="btn btn-primary"  ValidationGroup="grp2" OnClick="btn_find_email_Click" />
                </div>
          <br><br>
          <div id="div_date" runat="server" class="form-group" >
                    <asp:Label ID="Label1" runat="server">From : </asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="fromdates"
                        ErrorMessage="Date is required" ForeColor="Red" ValidationGroup="grp3"></asp:RequiredFieldValidator>

                    <asp:TextBox ID="fromdates" runat="server" Width="200px" class="form-control" ValidationGroup="grp2"></asp:TextBox>
                  <br>
              <asp:Label ID="Label2" runat="server">To : </asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="todates"
                        ErrorMessage="Date is required" ForeColor="Red" ValidationGroup="grp3"></asp:RequiredFieldValidator>

                    <asp:TextBox ID="todates" runat="server" Width="200px" class="form-control" ValidationGroup="grp3"></asp:TextBox>
              <br>
                    <asp:Button ID="btn_find_dates" runat="server" Text="Find" class="btn btn-primary"  ValidationGroup="grp3" OnClick="btn_find_dates_Click"/>
                </div>
         </div>
            <div class="col-md-5">
    <asp:GridView ID="Reports" runat="server" CssClass="mydatagrid" PagerStyle-CssClass="pager"
 HeaderStyle-CssClass="header" RowStyle-CssClass="rows" >

    </asp:GridView>
            </div>
</asp:Content>
