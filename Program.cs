using System;
// con la libreria ↓ System.Net ↓ podemos hacer peticiones http //
using System.Net;
// con la biblioteca ↓ Newtonsoft.Json ↓ podemos transformar los datos json a un objeto legible //
using Newtonsoft.Json;

namespace myfirstapp
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaramos una variable de tipo string para almacenar la dirección de la api a la que vamos a hacer la petición
            string URL_API = "https://jsonplaceholder.typicode.com/posts?_limit=5";

            //Creamos un nuevo objeto HttpClient para realizar la petición
            var client = new HttpClient();

            //Hacemos la petición con el metodo GetStringAsync que nos devuelve una cadena de texto con el resultado de la petición
            var json = client.GetStringAsync(URL_API).Result;

            dynamic obj = JsonConvert.DeserializeObject(json);

            foreach (var post in obj)
            {
                Console.WriteLine(post.id + ":" + post.title);
            }

        }
    }
}
