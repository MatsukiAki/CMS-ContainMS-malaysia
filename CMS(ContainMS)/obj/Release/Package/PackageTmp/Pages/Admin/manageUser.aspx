<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/SiteAdmin.Master" AutoEventWireup="true" CodeBehind="manageUser.aspx.cs" Inherits="CMS_ContainMS_.Pages.Admin.manageUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="col-md-3">
        </div>
   
   
    
        <div class="col-md-4" runat="server">
              <div class="form-group">
                    <asp:Label ID="lbl_register_email" runat="server">Email: </asp:Label>
                    <asp:RequiredFieldValidator ID="valid_reg_email" runat="server" ControlToValidate="txt_register_email"
                        ErrorMessage="Email is required" ForeColor="Red" ValidationGroup="grp2"></asp:RequiredFieldValidator>

                    <asp:TextBox ID="txt_register_email" runat="server" Width="200px" class="form-control" ValidationGroup="grp2"></asp:TextBox>
                  <br>
                    <asp:Button ID="Button1" runat="server" Text="Find" class="btn btn-primary"  ValidationGroup="grp2" OnClick="Button1_Click"/>
                </div>
    <asp:GridView ID="UserTbl" AutoGenerateSelectButton="True"  OnRowDataBound="OnRowDataBound" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" BorderStyle="Groove" BorderWidth="2px" OnSelectedIndexChanged="UserTbl_SelectedIndexChanged">
         
                <Columns>

                    <asp:BoundField DataField="Name" HeaderText="Name" ></asp:BoundField>                        
                    <asp:BoundField DataField="Email" HeaderText="Email"></asp:BoundField> 
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Email"></asp:BoundField>                        
                    <asp:BoundField DataField="PhoneNo" HeaderText="PhoneNo"></asp:BoundField>   
                    <asp:BoundField DataField="Type" HeaderText="Type" ></asp:BoundField> 
                    <asp:BoundField DataField="Status" HeaderText="Type" ></asp:BoundField> 
                    
                     
                </Columns>
    </asp:GridView>
    </div>
     <div class="col-md-3">
    
                
            
          
                <asp:Button ID="btn_activate" runat="server" class="btn btn-primary" Text="Activate"  ValidationGroup="grp2" OnClick="btn_activate_Click" />
        <asp:Button ID="btn_deactivate" runat="server" class="btn btn-primary" Text="DeActivate"  ValidationGroup="grp2" OnClick="btn_deactivate_Click" />
            </div>
</asp:Content>
