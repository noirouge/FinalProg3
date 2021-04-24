// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RClientes.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RClientes")]
    public partial class RClientes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 196 "D:\Tareas\5to Cuatrimestre\PROG 3\FINAL\Final\FinalProg3\Proyecto\Proyecto\Pages\RClientes.razor"
       

    /// ------------------------------- BEGIN ---------------------------------------

    Funciones fc = new Funciones();
    List<Clientes> clientes;
    /// ----------------------- VARIABLES --------------------------

    string NO = "NO";
    string YES = "YES";
    string urlFotoP = "";
    string urlFotoL = "";
    string mFotoP = "";
    string mFotoL = "";
    int editar = 0;
    int cambio = 0;
    int cambio2 = 0;

    /// VARIABLES DE DATOS
    string urlFotoPersona = "";
    string urlFotoLicencia = "";
    string ID = "";
    string Apellido = "";
    string Cedula = "";
    string Correo = "";
    string Licencia = "";
    string Nacionalidad = "";
    string Nombre = "";
    string Sangre = "A";



    // Booleanos

    bool vofTabla = false;
    bool vofFinish = false;
    bool vofEdit = false;

    //-----


    //----------------------- Cargar Imagenes --------------------------------
    async Task Cambio(IFileListEntry[] files)
    {
        await fc.CargarImagen(files);
        mFotoL = "Imagen Seleccionada:" + files.FirstOrDefault().Name;
        cambio = 1;

    }
    async Task Obtener()
    {

        urlFotoPersona = await fc.ObtenerURL();

    }
    async Task Cambio2(IFileListEntry[] files)
    {
        await fc.CargarImagen2(files);
        mFotoP = "Imagen Seleccionada:" + files.FirstOrDefault().Name;
        cambio2 = 1;

    }
    async Task Obtener2()
    {

        urlFotoLicencia = await fc.ObtenerURL2();

    }
    //------------------- METODOS RELACIONADOS A LA API -----------------

    async Task Guardar()
    {
        if (editar == 0)
        {
            await EnviarDatos();
        }
        else
        {
            await Update();
        }
    }

    async Task EnviarDatos()
    {
        await Obtener();
        await Obtener2();
        vofFinish = false;
        HttpClient http = new HttpClient();


        string URI = "https://finalprog3-930fc-default-rtdb.firebaseio.com/Clientes.json";

        var values = new Clientes { Apellido = Apellido, Cedula = Cedula, Correo = Correo, Estado = "YES", FotoL = urlFotoLicencia, FotoP = urlFotoPersona, Licencia = Licencia, Nacionalidad = Nacionalidad, Nombre = Nombre, Sangre = Sangre };
        var json = JsonConvert.SerializeObject(values, Formatting.Indented);

        var vehiculo = new StringContent(json);

        var res = await http.PostAsync(URI, vehiculo);
        if (res.IsSuccessStatusCode)
        {
            vofFinish = true;
            urlFotoPersona = "";
            urlFotoLicencia = "";
            ID = "";
            Apellido = "";
            Cedula = "";
            Correo = "";
            Licencia = "";
            Nacionalidad = "";
            Nombre = "";
            Sangre = "A";
            mFotoP = "";
            mFotoL = "";
            await OnInitializedAsync();
        }
    }

    void Edit(string id,
    string apellido,
    string cedula,
    string correo,
    string fotoL,
    string fotoP,
    string licencia,
    string nacionalidad,
    string nombre,
    string sangre

    )
    {
        vofFinish = false;

        editar = 1;
        ID = id;
        Apellido = apellido;
        Cedula = cedula;
        Correo = correo;
        urlFotoPersona = fotoP;
        urlFotoLicencia = fotoL;
        Licencia = licencia;
        Nacionalidad = nacionalidad;
        Nombre = nombre;
        Sangre = sangre;

        urlFotoL = urlFotoLicencia;
        urlFotoP = urlFotoPersona;


        vofEdit = true;



    }

    async Task Update()
    {
        if (cambio != 0)
        {
            await Obtener();

        }
        if(cambio2 != 0)
        {
            await Obtener2();
        }

        HttpClient http = new HttpClient();


        string URI = $"https://finalprog3-930fc-default-rtdb.firebaseio.com/Clientes/{ID}.json";

        var values = new Clientes { Apellido = Apellido, Cedula = Cedula, Correo = Correo, Estado = "YES", FotoL = urlFotoLicencia, FotoP = urlFotoPersona, Licencia = Licencia, Nacionalidad = Nacionalidad, Nombre = Nombre, Sangre = Sangre };
        var json = JsonConvert.SerializeObject(values, Formatting.Indented);

        var cliente = new StringContent(json);

        var response = http.PatchAsync(URI, cliente);
        if (response.Result.IsSuccessStatusCode)
        {
            vofEdit = false;
            editar = 0;
            vofFinish = true;
            cambio = 0;
            cambio2 = 0;

            urlFotoPersona = "";
            urlFotoLicencia = "";
            ID = "";
            Apellido = "";
            Cedula = "";
            Correo = "";
            Licencia = "";
            Nacionalidad = "";
            Nombre = "";
            Sangre = "A";
            mFotoP = "";
            mFotoL = "";


            await OnInitializedAsync();
        }
    }




    async Task ChangeStatus(string id, string status)
    {
        HttpClient http = new HttpClient();


        string URI = "https://finalprog3-930fc-default-rtdb.firebaseio.com/Clientes/";

        var values = new { Estado = status };
        var json = JsonConvert.SerializeObject(values, Formatting.Indented);

        var cliente = new StringContent(json);



        var response = await http.PatchAsync(URI + id + ".json", cliente);



        if (response.IsSuccessStatusCode)
        {
            await OnInitializedAsync();

        }

    }





    // ---------------------- Cargar Tabla ------------------------------
    protected override async Task OnInitializedAsync()
    {


        HttpClient http = new HttpClient();
        string URI = "https://finalprog3-930fc-default-rtdb.firebaseio.com/Clientes.json";

        var response = await http.GetAsync(URI);

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();

            var datos = JsonConvert.DeserializeObject<Dictionary<string, Clientes>>(content).ToList();

            var datos2 = from xd in datos
                         select new Clientes
                         {
                             ID = xd.Key,
                             Apellido = xd.Value.Apellido,
                             Cedula = xd.Value.Cedula,
                             Correo = xd.Value.Correo,
                             Estado = xd.Value.Estado,
                             FotoL = xd.Value.FotoL,
                             FotoP = xd.Value.FotoP,
                             Licencia = xd.Value.Licencia,
                             Nacionalidad = xd.Value.Nacionalidad,
                             Nombre = xd.Value.Nombre,
                             Sangre = xd.Value.Sangre



                         };

            clientes = datos2.ToList();
            vofTabla = true;


        }





    }

    // ---------------------------------- END ---------------------------------------

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
