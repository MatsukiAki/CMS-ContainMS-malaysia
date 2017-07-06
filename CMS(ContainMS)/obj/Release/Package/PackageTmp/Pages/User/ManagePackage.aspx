<%@ Page Language="C#" masterpagefile="~/Pages/User/Site.Master" AutoEventWireup="true" CodeBehind="ManagePackage.aspx.cs" Inherits="CMS_ContainMS_.CreatePackage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
    <div  class="col-md-3" >
                         </div>
                     <div class="col-md-3">


                        <fieldset class="sender_info">
                             <div class="form-group">
                                <label id="label_ID">
                                   Package ID :</label>                                
                                
                                <asp:TextBox ID="txt_package_id" runat="server" placeholder="ID" Enabled="false" class="form-contl" ></asp:TextBox>
                            </div>
                            <legend>Sender Information :</legend>
                            <div class="form-group">
                                <label id="label_name">
                                    Name :</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txt_send_add_name"
                                    ErrorMessage="* Required Field" ForeColor="Red" ValidationGroup="grp_add"></asp:RequiredFieldValidator>
                                <asp:TextBox ID="txt_send_add_name" runat="server" placeholder="Full Name" class="form-contl"></asp:TextBox>
                            </div>
                           
                            <div class="form-group">
                                <label id="label_email">
                                    Email Address :</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_send_add_email"
                                    ErrorMessage="* Required Field" ForeColor="Red" ValidationGroup="grp_add"></asp:RequiredFieldValidator>
                                <asp:TextBox ID="txt_send_add_email" runat="server" placeholder="email@example.com"
                                    class="form-contl" type="email"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label id="label_number">
                                    Cell number :</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_send_add_number"
                                    ErrorMessage="* Required Field" ForeColor="Red" ValidationGroup="grp_add"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txt_send_add_number"
                                    ErrorMessage="* invalid number format" ForeColor="Red" ValidationExpression="^((\+60(\s|-)?)|0)(((?!0)(?!2)(?!80)(?!81)\d{1,2})[1]?)(\s|-)?\d{2,4}(\s|-)?\d{4}$"
                                    ValidationGroup="grp_add"></asp:RegularExpressionValidator>
                                <asp:TextBox ID="txt_send_add_number" runat="server" placeholder="+60123456789" class="form-contl"></asp:TextBox>
                            </div>
                            <div class="form-group">

                               
                                <asp:TextBox ID="txt_send_add_pckg_w" placeholder="Weight in KG" runat="server" 
                                    class="form-contl"  Width="133px"></asp:TextBox>
                                <br>
                                <label id="label_State">
                                    Package :</label>
                                <asp:DropDownList ID="package" runat="server" AutoPostBack="true" OnSelectedIndexChanged="package_SelectedIndexChanged">
                                
                                    </asp:DropDownList>
                            </div>
                         <div class="form-group">
                                <label id="label_Price">
                                    Total Price :</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txt_price"
                                    ErrorMessage="* Required Field" ForeColor="Red" ValidationGroup="grp_add"></asp:RequiredFieldValidator><br>
                                <asp:TextBox ID="txt_price" runat="server" placeholder="Price"
                                     class="form-contl"  Enabled="false"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label id="label_address">
                                    Address :</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txt_send_add_address"
                                    ErrorMessage="* Required Field" ForeColor="Red" ValidationGroup="grp_add"></asp:RequiredFieldValidator>
                                <asp:TextBox ID="txt_send_add_address" runat="server" placeholder="Full Address"
                                    Height="80px" class="form-contl" TextMode="MultiLine" Style="resize: none;"></asp:TextBox>
                            </div>
                       
                            
                             </fieldset>




                    </div>
                              
                    <div class="col-md-4">
                        <fieldset class="rec_info">
                            <legend>Receiver Information :</legend>
                            <div class="form-group">
                                <label id="label_name2">
                                    Name :</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txt_receive_add_name"
                                    ErrorMessage="* Required Field" ForeColor="Red" ValidationGroup="grp_add"></asp:RequiredFieldValidator>
                                <asp:TextBox ID="txt_receive_add_name" runat="server" placeholder="Full Name" class="form-contl"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label id="label_email2">
                                    Email Address :</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txt_receive_add_email"
                                    ErrorMessage="* Required Field" ForeColor="Red" ValidationGroup="grp_add"></asp:RequiredFieldValidator>
                                <asp:TextBox ID="txt_receive_add_email" runat="server" placeholder="email@example.com"
                                    class="form-contl" type="email"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label id="label_number2">
                                    Cell number :</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txt_receive_add_number"
                                    ErrorMessage="* Required Field" ForeColor="Red" ValidationGroup="grp_add"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="txt_receive_add_number"
                                    ErrorMessage="* invalid number format" ForeColor="Red" ValidationExpression="^((\+60(\s|-)?)|0)(((?!0)(?!2)(?!80)(?!81)\d{1,2})[1]?)(\s|-)?\d{2,4}(\s|-)?\d{4}$"
                                    ValidationGroup="grp_add"></asp:RegularExpressionValidator>
                                <asp:TextBox ID="txt_receive_add_number" runat="server" placeholder="+60123456789"
                                    class="form-contl"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label id="label_date2">
                                    Estimated Delivery Date :</label>
                                <asp:TextBox ID="txt_receive_add_date" runat="server" placeholder="mm/dd/yyyy" class="form-contl"
                                    ReadOnly="True"></asp:TextBox>
                            </div>
                            <div class="form-group" id="address2group">
                                <label id="label_address2">
                                    Address :</label>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txt_receive_add_address"
                                    ErrorMessage="* Required Field" ForeColor="Red" ValidationGroup="grp_add"></asp:RequiredFieldValidator>
                                <asp:TextBox ID="txt_receive_add_address" runat="server" placeholder="Full Address"
                                    Height="80px" class="form-contl" TextMode="MultiLine" Style="resize: none;"></asp:TextBox>
                            </div>
                        </fieldset>
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn btn-primary" 
                            ValidationGroup="grp_add" OnClick="btnSubmit_Click" />
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" class="btn btn-danger" OnClick="btnDelete_Click"
                            ValidationGroup="grp_delete" />
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-success" OnClick="btnUpdate_Click"
                            ValidationGroup="grp_update" />
                        <br>
                    </div>
  
     


<script type="text/jscript">
    $(function () {
        $("#txt_send_update_date,#txt_send_add_date,#txt_send_delete_date").datepicker({
            showOn: "button",
            buttonImage: "http://icons.iconarchive.com/icons/martz90/circle/24/calendar-icon.png",
            buttonImageOnly: true,
            buttonText: "Select date",
            changeMonth: true,
            changeYear: true,
            maxDate: "+6M",
            minDate: "+1D",
            dateFormat: 'dd-mm-yy'
        });
    });


</script>
</asp:Content>