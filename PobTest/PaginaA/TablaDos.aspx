<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TablaDos.aspx.cs" Inherits="PobTest.PaginaA.TablaDos" %>



<table class="table" id="tablaDos">
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
