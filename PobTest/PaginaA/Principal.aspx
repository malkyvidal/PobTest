<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="PobTest.PaginaA.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .err{
            border:solid;
            border-color:red
        }
    </style>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <script src="../Scripts/jquery-3.1.1.js"></script>
    

    <script>

        function addOption(value, text) {

            return '<option value=' + value + '>' + text + '</option>';
        }

        function generarOptions(lista,value, text) {
            var options = $.map(lista, function (c, i) {
                
                return addOption(c[value], c[text]);
            }).join('');
            return options;
        }
        var materiasObtenidas = [];
        var materiasObtenidasTodas = [];
        $(document).ready(function () {

            $("#ddlDep").on("change", function () {

                $("#carreraContainer").load("<%= GetCarreraComboUrl()%>" + $(this).val())
            });



            $("#tblUnoContainer ").on("change", "td select", function (e) {
                var selecc = $(this).val();
                $(this).removeClass("err");
                
                $(this).parent("td").children().remove("span");
                var noEstaSeleccionada = materiasObtenidas.indexOf(selecc) == -1 ;
                console.log(noEstaSeleccionada);
                if (noEstaSeleccionada ) {
                    materiasObtenidas.push(selecc);
                }
                else {
                    if (selecc!="0") {
                        $(this).addClass("err");
                        $(this).parent("td").append("<span>la materia ya fue elegida</span>");
                    }
                   
                }
                
                
               

            });

            $("#carreraContainer").on("change", "#carreras", function (e) {

                var seleccion = $(this).val();
                if (seleccion!="0") {

                    //$("#tblUnoContainer").load("TablaCarrerasUno.aspx");
                   // var promise1 = $.get("TablaCarrerasUno.aspx");
                    //var promise2 = $.getJSON("Materias.aspx");

                    //promise2.then(function (res) {
                    //    console.log(res);
                    //}, function (a,b,c) {
                    //    console.log(a);
                    //    console.log(b);
                    //    console.log(c);
                    //});

                    //$.when($.get("TablaCarrerasUno.aspx"), $.getJSON("Materias.aspx?idCarrera="+seleccion))
                    //.then(function (response1, response2) {

                       
                        

                    //    console.log(response1[0]);
                    //    console.log(response2[0]);
                    //}, function (a, b,c) {
                    //    console.log(a);
                    //    console.log(b);
                    //    console.log(c);
                    //})

                    // var promises = $.get("TablaDos.aspx");


                    $.getJSON("Materias.aspx?idCarrera=" + seleccion).then(function (response) {

                        $("#tblUnoContainer").load("TablaCarrerasUno.aspx", function () {

                          
                            //var options = $.map(response, function (c, i) {
                            //    console.log(c["IdMateria"]);
                            //    console.log(c["Nombre"]);
                            //    return addOption(c.IdMateria, c.Nombre);
                            //}).join('');

                          
                            materiasObtenidasTodas = $.map(response, function (c, i) {
                                return c;
                            });
                            var options2 = generarOptions(response, "IdMateria", "Nombre");

                            $("td select").each(function (i, item) {
                                $(this).append(options2);
                            });


                            

                        });

                    },
                    function () {
                        console.log("error")
                    }).then(function () {

                        
                        $("#tblDosContainer").load("TablaDos.aspx");
                      
                        

                    }, function () {
                        console.log("err");
                    });

                }
            })

        })
    </script>

</head>
<body>
    <form id="form1"  runat="server">
    <div>
        
     
        <select id="ddlDep" runat="server"></select>
        <div id="carreraContainer">

        </div>
        
        <div id="tblUnoContainer" class="form-group">

        </div>
        <div id="tblDosContainer" >

        </div>
    </div>
    </form>
    <script src="../Scripts/bootstrap.js"></script>
</body>
</html>
