<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TablaCarrerasUno.aspx.cs" Inherits="PobTest.PaginaA.TablaCarrerasUno" %>


<table class="table" id="tablaUno">
    <thead>
        <tr>
            <td>Codigo</td>
            <td>Evaluacion</td>
            <td>Materia</td>
        </tr>
    </thead>
   <tbody>
       <%foreach(var fila in CrearFilas()) %>
      <%{ %>
       <%=fila %>
       <%} %>
   </tbody>

</table>
