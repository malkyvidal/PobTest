<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestWF.aspx.cs" Inherits="PobTest.PaginaA.TestWF" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="../Scripts/jquery-3.1.1.js"></script>
    <style>
        .err{
            border:solid;
            border-color:red
        }
        .sp{
            color:red;
            font-size:small;
        }
    </style>
    <script>
       

        $(document).ready(function () {

            $("#form1").on("submit", function (e) {

               
               
               
                if ($("#<%= hdnMr.ClientID%>").val()=="1") {
                    e.preventDefault();
                }
            })
        })

      
    </script>
</head>
<body>
    <form id="form1" runat="server">

        <asp:HiddenField ID="hdnMr" Value="0"  runat="server" />

        <table id="tabela">
            <thead>
                <tr>
                    <td>Codigo</td>
                    <td>Valoracion</td>
                    <td>Materia</td>
                </tr>

            </thead>
            <tbody>
               
                <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound">
                    <ItemTemplate>
                        <tr>
                            <td>
                                
                            <asp:TextBox  ID="TextBox1" Text='<%#Eval("Codigo") %>' runat="server"></asp:TextBox>
                            </td>
                            <td>
                                
                            <asp:TextBox ID="TextBox2" Text='<%#Eval("evaluacion") %> ' runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:DropDownList AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" ID="DropDownList1" runat="server" ></asp:DropDownList>
                                
                                <asp:Label ID="LblMensaje" Visible="false" runat="server" CssClass="sp" Text="La Materia ya fue seleccionada. Elija Otra"></asp:Label>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>
</body>
</html>
