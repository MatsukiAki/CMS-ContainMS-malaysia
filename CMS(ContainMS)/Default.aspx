<%@ Page Title="Welcome to CMS" Language="C#"  AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CMS_ContainMS_._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head  runat="server">
     <link href="~/Styles1/bootstrap.min.css" rel="stylesheet" type="text/css" />
     <link href="~/Styles1/Style.css" rel="stylesheet" type="text/css" />
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    
</head>
<body>
    <div class="container">
    <div class="header">
        <h1>Container Delivery Management System</h1>
    </div>
    <form id="form2" runat="server" >
    <div class="row">
    <div class="col-md-6">
    <img src="Images/dms.png" alt="picture" style="width:500px; height: 600px"/>
    </div>
        <div class="col-md-6">
            
    
            <div class="login">
            <fieldset class="log_in">
                <legend>Log In</legend>
                    <div class ="form-group">
                    <asp:Label ID="lbl_login_username" runat="server">User Name: </asp:Label>
                        <asp:RequiredFieldValidator
                            ID="valid_login_username"
                            runat="server" 
                            EnableViewState="False"
                            ForeColor="Red"  
                            ControlToValidate="userName" 
                            ErrorMessage="User name is required" 
                            SetFocusOnError="True" 
                            ValidationGroup="grp1">User name is require                        </asp:RequiredFieldValidator>
                        
                    <asp:TextBox ID="userName" runat="server" class="form-control"></asp:TextBox>
                    </div>
                    <div class ="form-group">
                    <asp:Label ID="lbl_login_pass" runat="server">Password: </asp:Label>
                        <asp:RequiredFieldValidator ID="valid_login_pass" runat="server" 
                            ErrorMessage="Password is required" ControlToValidate="password" 
                            AutoPostBack="false" ForeColor="Red" SetFocusOnError="True" ValidationGroup="grp1" ></asp:RequiredFieldValidator>
                    <asp:TextBox ID="password" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                                              
                    </div>
            </fieldset>
            
                <asp:Button ID="btn_login" runat="server" Text="Log In" 
                    class="btn btn-primary" onclick="btn_login_Click" ValidationGroup="grp1" /> 
                    
                    <span class="psw">
                
                <span class="registers"><a onclick="document.getElementById('id01').style.display='block'">
                    Register</a></span>
        </div>
    </div>
    </div>

        <div runat="server" style="float:right"> 

            <asp:Label ID="cu" runat="server" Text="Currently visting this webiste from Malaysia"></asp:Label>
            

            </div>

    <div id="id01" class="modal">
        <div class="modal-content animate">
        <div class="imgcontainer">
        <span onclick="document.getElementById('id01').style.display='none'" class="close"
                title="Close Modal">&times;</span>
        <img src="Images/dms.png" alt="picture" class="avatar"/>
        </div>
            
            <div class="modal-container">
                <div class="form-group">
                    <asp:Label ID="lbl__register_username" runat="server">Name: </asp:Label>
                    <asp:RequiredFieldValidator ID="valid_reg_username" runat="server" ControlToValidate="txt_register_username"
                        ErrorMessage="User Name is required" ForeColor="Red" ValidationGroup="grp2"></asp:RequiredFieldValidator>
                    <asp:TextBox ID="txt_register_username" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lbl_register_email" runat="server">Email: </asp:Label>
                    <asp:RequiredFieldValidator ID="valid_reg_email" runat="server" ControlToValidate="txt_register_email"
                        ErrorMessage="Email is required" ForeColor="Red" ValidationGroup="grp2"></asp:RequiredFieldValidator>

                    <asp:TextBox ID="txt_register_email" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lbl_register_pass" runat="server">Password: </asp:Label>
                    <asp:RequiredFieldValidator ID="valid_reg_pass" runat="server" ControlToValidate="txt_register_pass"
                        ErrorMessage="Password is required" ForeColor="Red" ValidationGroup="grp2"></asp:RequiredFieldValidator>

                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txt_register_pass" runat="server" TextMode="Password" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lbl__register_confirmpass" runat="server">Confirm Password: </asp:Label>
                    <asp:RequiredFieldValidator ID="valid_reg_confpass" runat="server" ControlToValidate="txt_register_confirmpass"
                        ErrorMessage="Confirm Password" ForeColor="Red" ValidationGroup="grp2"></asp:RequiredFieldValidator>
                    &nbsp;<br />
                    <asp:CompareValidator ID="valid_conf" runat="server" ControlToCompare="txt_register_pass"
                        ControlToValidate="txt_register_confirmpass" ErrorMessage="Confirmation does not match with password!"
                        ForeColor="Red" ValidationGroup="grp2"></asp:CompareValidator>
                    <asp:TextBox ID="txt_register_confirmpass" runat="server" TextMode="Password" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lbl_register_address" runat="server">Address: </asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_register_address"
                        ErrorMessage="Address is required" ForeColor="Red" ValidationGroup="grp2"></asp:RequiredFieldValidator>
                    <asp:TextBox ID="txt_register_address" runat="server" class="form-control" TextMode="MultiLine" style="resize:none;"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lbl_register_phone" runat="server">Phone number: </asp:Label>
                    <asp:RequiredFieldValidator ID="valid_register_phone" runat="server" ControlToValidate="txt_register_phone"
                        ErrorMessage="Phone number is required" ForeColor="Red" ValidationGroup="grp2"></asp:RequiredFieldValidator>
                    <asp:TextBox ID="txt_register_phone" runat="server" class="form-control"></asp:TextBox>
                </div>

                
                <asp:Button ID="btn_register" runat="server" onclick="btn_register_Click" Text="Register" class="btn btn-primary"
                    ValidationGroup="grp2" />
                
            </div>
        </div>
    </div>
    
     </form>
</div>


</body>

</html>
