#pragma checksum "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7554dab4327a9beac48df00d73118bee89e23c6d"
// <auto-generated/>
#pragma warning disable 1591
namespace Proyecto.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using Proyecto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using Proyecto.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\_Imports.razor"
using MoreLinq.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RFacturas")]
    public partial class RFacturas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
#nullable restore
#line 7 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
         if (vofCarga)
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
             foreach (var x in facturas)
            {

                Clientes Cli = clientes.First(z => z.ID == x.ClienteID);
                Vehiculos Vehi = vehiculos.First(y => y.ID == x.VehiculoID);



#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card mt-3 ml-3 mr-3");
            __builder.AddAttribute(6, "style", "width: 20rem");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-header");
            __builder.OpenElement(9, "h2");
#nullable restore
#line 20 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
                             if (x.Pagada == "YES")
                            {



#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<b>PAGADO</b>");
#nullable restore
#line 25 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<b>SIN PAGAR</b>");
#nullable restore
#line 29 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-body");
            __builder.OpenElement(15, "p");
            __builder.AddContent(16, "Cliente: ");
            __builder.AddContent(17, 
#nullable restore
#line 35 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
                                 Cli.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(18, " ");
            __builder.AddContent(19, 
#nullable restore
#line 35 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
                                             Cli.Apellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "p");
            __builder.AddContent(22, "Cedula: ");
            __builder.AddContent(23, 
#nullable restore
#line 36 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
                                Cli.Cedula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "p");
            __builder.AddContent(26, "Vehiculo: ");
            __builder.AddContent(27, 
#nullable restore
#line 37 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
                                  Vehi.Marca

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(28, " - ");
            __builder.AddContent(29, 
#nullable restore
#line 37 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
                                                Vehi.Modelo

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(30, " - ");
            __builder.AddContent(31, 
#nullable restore
#line 37 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
                                                               Vehi.Color

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(32, " - ");
            __builder.AddContent(33, 
#nullable restore
#line 37 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
                                                                             Vehi.Year

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "p");
            __builder.AddContent(36, "Matricula: ");
            __builder.AddContent(37, 
#nullable restore
#line 38 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
                                   Vehi.Matricula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "p");
            __builder.AddContent(40, "Desde: ");
            __builder.AddContent(41, 
#nullable restore
#line 39 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
                               x.Desde

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "p");
            __builder.AddContent(44, "Hasta: ");
            __builder.AddContent(45, 
#nullable restore
#line 40 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
                               x.Hasta

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.OpenElement(47, "p");
            __builder.AddContent(48, "Monto: ");
            __builder.AddContent(49, 
#nullable restore
#line 41 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
                               x.Monto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.OpenElement(51, "p");
            __builder.AddContent(52, "Deuda: ");
            __builder.AddContent(53, 
#nullable restore
#line 42 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
                               x.Debe

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.OpenElement(55, "p");
            __builder.AddContent(56, "Pagado: ");
            __builder.AddContent(57, 
#nullable restore
#line 43 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
                                x.Pagado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "card-footer");
#nullable restore
#line 47 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
                     if (x.Pagada == "NO")
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(61, "button");
            __builder.AddAttribute(62, "class", "btn btn-success btn-block");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
                                                                            (() => Pagar(x.ID, x.Debe))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(64, "\r\n                            Pagar\r\n                        ");
            __builder.CloseElement();
#nullable restore
#line 52 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(65, "<button class=\"btn btn-dark btn-block\" disabled>\r\n                            Pagar\r\n                        </button>");
#nullable restore
#line 58 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
         


        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 70 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
     if(vofPago) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "contenedor-modal");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "ventana");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "card");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "card-header");
            __builder.OpenElement(74, "button");
            __builder.AddAttribute(75, "class", "btn btn-danger btn-block");
            __builder.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
                                                       Cerrar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(77, "CERRAR");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "card-body");
            __builder.OpenElement(81, "input");
            __builder.AddAttribute(82, "class", "form-control");
            __builder.AddAttribute(83, "type", "number");
            __builder.AddAttribute(84, "min", "0");
            __builder.AddAttribute(85, "max", 
#nullable restore
#line 78 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
                                                                                         pag

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(86, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 78 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
                                                       pago

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(87, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => pago = __value, pago, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "card-footer");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "btn btn-primary btn-block");
            __builder.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
                                                                     Pagando

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(94, "PAGAR");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 86 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
    
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 92 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RFacturas.razor"
           

        bool vofCarga = false;
        bool vofPago = false;

        List<Vehiculos> vehiculos;
        List<Clientes> clientes;
        List<Factura> facturas;

        double pago = 0;

        string ID = "";
        double pag = 0;
        protected override async Task OnInitializedAsync()
        {

            string urlV = "https://finalprog3-930fc-default-rtdb.firebaseio.com/Vehiculos.json";
            string urlF = "https://finalprog3-930fc-default-rtdb.firebaseio.com/Facturas.json";
            string urlC = "https://finalprog3-930fc-default-rtdb.firebaseio.com/Clientes.json";

            HttpClient http = new HttpClient();

            var resV = await http.GetAsync(urlV);
            if (resV.IsSuccessStatusCode)
            {
                var content = await resV.Content.ReadAsStringAsync();

                var dVehiculos = JsonConvert.DeserializeObject<Dictionary<string, Vehiculos>>(content);

                var dVehiculos2 = from x in dVehiculos
                                  select new Vehiculos
                                  {
                                      ID = x.Key,
                                      Carga = x.Value.Carga,
                                      Color = x.Value.Color,
                                      Estado = x.Value.Estado,
                                      Foto = x.Value.Foto,
                                      Lat = x.Value.Lat,
                                      Lng = x.Value.Lng,
                                      Marca = x.Value.Marca,
                                      Matricula = x.Value.Matricula,
                                      Modelo = x.Value.Modelo,
                                      Pasajeros = x.Value.Pasajeros,
                                      Price = x.Value.Price,
                                      Seguro = x.Value.Seguro,
                                      Tipo = x.Value.Tipo,
                                      Year = x.Value.Year



                                  };

                vehiculos = dVehiculos2.ToList();
                //------------------------
                var resC = await http.GetAsync(urlC);
                if (resC.IsSuccessStatusCode)
                {
                    var content2 = await resC.Content.ReadAsStringAsync();

                    var dClientes = JsonConvert.DeserializeObject<Dictionary<string, Clientes>>(content2);

                    var dClientes2 = from x in dClientes
                                     select new Clientes
                                     {

                                         ID = x.Key,
                                         Apellido = x.Value.Apellido,
                                         Cedula = x.Value.Cedula,
                                         Correo = x.Value.Correo,
                                         Estado = x.Value.Estado,
                                         FotoL = x.Value.FotoL,
                                         FotoP = x.Value.FotoP,
                                         Licencia = x.Value.Licencia,
                                         Nacionalidad = x.Value.Nacionalidad,
                                         Nombre = x.Value.Nombre,
                                         Sangre = x.Value.Sangre




                                     };

                    clientes = dClientes2.ToList();

                    var resF = await http.GetAsync(urlF);

                    if(resF.IsSuccessStatusCode)
                    {
                        var content3 = await resF.Content.ReadAsStringAsync();

                        var dFacturas = JsonConvert.DeserializeObject<Dictionary<string, Factura>>(content3);

                        var dFacturas2 = from x in dFacturas
                                         select new Factura
                                         {
                                             ID = x.Key,
                                             ClienteID = x.Value.ClienteID,
                                             Debe = x.Value.Debe,
                                             Desde = x.Value.Desde,
                                             Estado = x.Value.Estado,
                                             Monto = x.Value.Monto,
                                             Pagada = x.Value.Pagada,
                                             Pagado = x.Value.Pagado,
                                             VehiculoID = x.Value.VehiculoID,
                                             Hasta = x.Value.Hasta



                                         };

                        facturas = dFacturas2.Reverse().ToList();

                    }


                }



            }


            vofCarga = true;
        }

        void Pagar(string id, string debe)
        {
            vofPago = true;

            pag = Convert.ToDouble(debe);
            pago = pag;
            ID = id;


        }

        void Cerrar()
        {
            vofPago = false;
        }

        async Task Pagando()
        {
            HttpClient http = new HttpClient();

            string URI = $"https://finalprog3-930fc-default-rtdb.firebaseio.com/Facturas/{ID}.json";
            double num = pag - pago;
            if(num == 0)
            {
                var data = new { Pagada = "YES", Debe = num.ToString(), Pagado = pago.ToString() };

                var json = JsonConvert.SerializeObject(data, Formatting.Indented);

                var data2 = new StringContent(json);


                var response = await http.PatchAsync(URI, data2);

                if (response.IsSuccessStatusCode)
                {
                    vofCarga = false;
                    await OnInitializedAsync();

                    pago = 0;
                    ID = "";
                    pag = 0;
                    vofPago = false;

                }

            }
            else
            {
                var data = new { Debe = num.ToString(), Pagado = pago.ToString()};

                var json = JsonConvert.SerializeObject(data, Formatting.Indented);

                var data2 = new StringContent(json);


                var response = await http.PatchAsync(URI, data2);

                if(response.IsSuccessStatusCode)
                {
                    vofCarga = false;
                    await OnInitializedAsync();

                    pago = 0;
                    ID = "";
                    pag = 0;
                    vofPago = false;

                }



            }



        }

    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
