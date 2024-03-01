<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Restaurant.aspx.cs" Inherits="Practice2.Restaurant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Restaurant</title>
    <style>
        .container {
            max-width: 500px;
            margin: 0 auto;
        }

        .info {
            display: flex;
        }

        .choix, 
        .evaluation {
            /*max-width: 400px;*/
            width: 50%;
        }

        h1,
        h2 {
            text-align: center;
        }

        h3 {
            border: 1px solid #000;
        }

    </style>
</head>
<body>
    <div class="container">
        <h1>RESTAURANTE DEL TIGRE</h1>
        <h2>Evaluation d'une visite gastronomique</h2>
        
        <form runat="server">
            <asp:Panel ID="infoPanel" runat="server" GroupingText="Informations personnelles">
                <asp:Label id="lblNom" runat="server" Text="Votre nom: "></asp:Label>
                <asp:TextBox ID="txtNom" runat="server" AutoPostBack="true" OnTextChanged="txtNom_TextChanged"></asp:TextBox>
                <br />
        
                <asp:Label id="lblTitre" runat="server" Text="Votre Titre: "></asp:Label>
                <asp:RadioButtonList ID="lstRbtnGender" runat="server" AutoPostBack="true" OnSelectedIndexChanged="lstRbtnGender_SelectedIndexChanged">

                </asp:RadioButtonList>
                <br />

                <div class="info">
                    <div class="choix">
                        <h3>Vos choix</h3>
                        <br />

                        <asp:Label id="lblEntree" runat="server" Text="Votre entrée: "></asp:Label>
                        <asp:DropDownList ID="lstDDEntry" runat="server" AutoPostBack="true" OnSelectedIndexChanged="lstDDEntry_SelectedIndexChanged">

                        </asp:DropDownList>
                        <br />

                        <asp:Label id="lblPlat" runat="server" Text="Votre plat: "></asp:Label>
                        <asp:ListBox ID="lstBPlat" runat="server" AutoPostBack="true" OnSelectedIndexChanged="lstBPlat_SelectedIndexChanged">

                        </asp:ListBox>
                        <br />
                
                        <asp:Label id="lblDessert" runat="server" Text="Votre dessert: "></asp:Label>
                        <asp:RadioButtonList ID="lstRbtnDessert" runat="server" AutoPostBack="true" OnSelectedIndexChanged="lstRbtnDessert_SelectedIndexChanged">

                        </asp:RadioButtonList>
                        <br />
                
                        <asp:Label id="lblBoisson" runat="server" Text="Votre boisson: "></asp:Label>
                        <asp:CheckBoxList ID="lstChkBoisson" runat="server" AutoPostBack="true" OnSelectedIndexChanged="lstChkBoisson_SelectedIndexChanged">

                        </asp:CheckBoxList>
                        <br />

                    </div>
            
                    <div class="evaluation" id="evaluation" runat="server">
                        <h3>Evaluation</h3>
                        <br />

                        <asp:Label id="lblEvaluation" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </asp:Panel>
        </form>
    </div>
        
</body>
</html>
