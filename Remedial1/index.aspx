<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Remedial1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Estilos.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="catalogo">
            <center>
                <h1>BIENVIENIDO A CATALOGOS INFORMATICOS</h1>
                <h2>Inserta un Catalogo</h2>
                <p>
                    <asp:Label ID="Label1" runat="server" Text="Nombre Categoria: "></asp:Label>
                    <asp:TextBox ID="txtcatalogo" runat="server" Width="177px"></asp:TextBox>
                </p>
                <p>
                    <asp:Label ID="Label2" runat="server" Text="Nombre de la Marca: "></asp:Label>
                    <asp:TextBox ID="txtmarca" runat="server" Width="156px"></asp:TextBox>
                </p>
                <p>
                    &nbsp;</p>
                <p>
                    <asp:Button ID="Button1" runat="server" Text="Insertar Catalogo" OnClick="Button1_Click" />
                &nbsp;&nbsp;
                    <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Insertar al Inicio" Width="152px" />
                </p>
                <p>
                    <asp:TextBox ID="txtinsercion" runat="server" style="margin-bottom: 0px" Width="450px"></asp:TextBox>
                </p>

                <h2>Mostrar Catalogos</h2>
                <p>
                    <asp:Button ID="Button2" runat="server" Text="Mostrar Catalogos" OnClick="Button2_Click" />
                </p>
                <p>
                    <asp:ListBox ID="ListBox1" runat="server" Height="161px" Width="652px"></asp:ListBox>
                </p>
                <h2>Buscar o Eliminar&nbsp; Catalogo</h2>
                <p>
                    <asp:Label ID="Label4" runat="server" Text="Nombre Categoria: "></asp:Label>
                    <asp:TextBox ID="txtcatalogob" runat="server" Width="163px"></asp:TextBox>
                </p>
                <p>
                    <asp:Label ID="Label5" runat="server" Text="Nombre Marca:"></asp:Label>
                    <asp:TextBox ID="txtmarcab" runat="server" Width="167px"></asp:TextBox>
                </p>
                <p>
                    <asp:Button ID="Button3" runat="server" Text="Buscar el catalogo" Width="196px" OnClick="Button3_Click" />
                &nbsp;<asp:Button ID="Button4" runat="server" Text="Eliminar catalogo" Width="197px" OnClick="Button4_Click" />
                </p>
                <p style="margin-left: 40px">
                    <asp:TextBox ID="TextBox5" runat="server" Height="43px" Width="545px"></asp:TextBox>
                </p>
                
                <h2>Insertar Imagen a catalogo</h2>
                <p>
                    
                <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="true" />
                <p>
                    <asp:Label ID="Label6" runat="server" Text="Nombre Categoria: "></asp:Label>
                    &nbsp;<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </p>
                <p>
                    <asp:Label ID="Label7" runat="server" Text="Nombre Marca:"></asp:Label>
                    <asp:TextBox ID="TextBox8" runat="server" Width="161px"></asp:TextBox>
                </p>
                <p>
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Insertar Imagen" Width="194px" />
                </p>
                <p style="margin-left: 40px">
                    <asp:TextBox ID="TextBox6" runat="server" Height="16px" Width="421px"></asp:TextBox>
                </p>
                <br />
                <br />
                    <h2>Mostrar Imagenes</h2>

                
                <br />
                <asp:Label ID="Label8" runat="server" Text="Nombre de categoria: "></asp:Label>
                <asp:TextBox ID="txtcategoriaM" runat="server" Height="16px" Width="205px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label9" runat="server" Text="Nombre de la marca: "></asp:Label>
                <asp:TextBox ID="txtmarcaM" runat="server" Width="204px"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Mostrar Imagenes" Width="139px" />
                &nbsp;&nbsp;
                <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Eliminar Imagen Cima" Width="159px" />
                <br />
                <br />
                <asp:Label ID="Label10" runat="server"></asp:Label>

                
                <br />
                <br />
                <br />
                <br />
                <br />

                <h2>Grafico de Listas dobles</h2>
                <p>
                    <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Mostrar Grafico" Width="151px" />
                </p>
                <p>
                    <asp:Image ID="Image1" runat="server" />
                </p>
            </center>
        </div>
    </form>
</body>
</html>
