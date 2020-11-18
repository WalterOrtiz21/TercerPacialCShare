using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace TercerParcial_Ortiz
{
    public class Dolar
    {

        public static async Task<string> ObtenerCambios()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://dolar.melizeche.com/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage respuesta = await client.GetAsync("1.0/");
                if (respuesta.IsSuccessStatusCode)
                {
                    var cambios = respuesta.Content.ReadAsStringAsync().Result;
                    return cambios;
                }
            }

            return null;
        }

    }
}