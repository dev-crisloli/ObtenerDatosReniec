using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace datosReniec
{
    public class getReniec
    {
        string nombres;
        string primerApellido;
        string segundoApellido;
        string[] nombreCompleto;
        string dni;
        string codigoVerificador;

        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string[] NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public string Dni { get => dni; set => dni = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string CodigoVerificador { get => codigoVerificador; set => codigoVerificador = value; }

        public void obtenerDatosReniec()
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Requestverificationtoken", "Dmfiv1Unnsv8I9EoXEzbyQExSD8Q1UY7viyyf_347vRCfO-1xGFvDddaxDAlvm0cZ8XgAKTaWclVFnnsGgoy4aLlBGB5m-E8rGw_ymEcCig1:eq4At-H2zqgXPrPnoiDGFZH0Fdx5a-1UiyVaR4nQlCvYZzAhzmvWxLwkUk6-yORYrBBxEnoG5sm-Hkiyc91so6-nHHxIeLee5p700KE47Cw1");
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Requestverificationtoken", "Dmfiv1Unnsv8I9EoXEzbyQExSD8Q1UY7viyyf_347vRCfO-1xGFvDddaxDAlvm0cZ8XgAKTaWclVFnnsGgoy4aLlBGB5m-E8rGw_ymEcCig1:eq4At-H2zqgXPrPnoiDGFZH0Fdx5a-1UiyVaR4nQlCvYZzAhzmvWxLwkUk6-yORYrBBxEnoG5sm-Hkiyc91so6-nHHxIeLee5p700KE47Cw1");
            string codificacionEnvioDatos = "application/json"; //Formulario
            StringContent jsonContentEnvioDatos = new StringContent("{\"CODDNI\": \"" + Dni + "\"}", Encoding.UTF8, codificacionEnvioDatos);
            HttpResponseMessage datosReniecPostJSON;

            datosReniecPostJSON = client.PostAsync("https://aplicaciones007.jne.gob.pe/srop_publico/Consulta/api/AfiliadoApi/GetNombresCiudadano", jsonContentEnvioDatos).Result;
            string obtieneCodigoRandomHTML = datosReniecPostJSON.Content.ReadAsStringAsync().Result;
            datosReniec datosReniec = JsonSerializer.Deserialize<datosReniec>(obtieneCodigoRandomHTML);
            string[] nombreCompleto = datosReniec.data.Split('|');

            PrimerApellido = nombreCompleto[0];
            SegundoApellido = nombreCompleto[1];
            Nombres = nombreCompleto[2];
            CodigoVerificador = codicoVerificadorDNI().ToString();
        }


        public int codicoVerificadorDNI()
        {
            int suma = 5;
            int len = Dni.Length;
            int[] hash = new int[] { 3, 2, 7, 6, 5, 4, 3, 2 };
            for (int i = 0; i < len; ++i)
            {
                suma += int.Parse(Dni.Substring(i,1)) * hash[i];
            }
            int entero = (int)(suma / 11);
            int digito = 11 - (suma - entero * 11);

            return digito > 9 ? digito - 10 : digito;
        }


    }

    public class datosReniec
    {
        string Data;
        Boolean Success;
        string Mensaje;

        public string data { get => Data; set => Data = value; }
        public Boolean success { get => Success; set => Success = value; }
        public string mensaje { get => Mensaje; set => Mensaje = value; }
    }
}
