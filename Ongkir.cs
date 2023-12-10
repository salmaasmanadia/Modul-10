using RestSharp;


namespace Modul_10
{
    public class Ongkir
    {
        public static List<string> GetKotaList()
        {
            List<string> list = new List<string>();

            var client = new RestClient("https://rajaongkir.com/starter/city");
            var request = new RestRequest(Method.GET);
            request.AddHeader("key", "c31a7ac4eaed9d6d966f5af4cf2aa4b9");

            IRestResponse response = client.Execute(request);
            RestSharp.JsonObject obj = (RestSharp.JsonObject)SimpleJson.DeserializeObject(response.Content);
            RestSharp.JsonObject rajaObj = (RestSharp.JsonObject)obj["rajaongkir"];
            RestSharp.JsonArray cityListArray = (RestSharp.JsonArray)rajaObj["results"];

            foreach (RestSharp.JsonObject city in cityListArray)
            {
                list.Add((string)city["city_name"]);
            }

            return list;
        }
        public static List<string> GetLayananList(int idAsal, int idTujuan, int berat, string kurir)
        {
            List<string> returnlist = new List<string>();
            var client = new RestClient("https://api.rajaongkir.com/starter/cost");
            var request = new RestRequest(Method.POST);

            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddHeader("key", "c31a7ac4eaed9d6d966f5af4cf2aa4b9");
            request.AddParameter("application/x-www-form-urlencoded",
                $"origin={idAsal.ToString()}&destination={idTujuan.ToString()}" +
                $"&weight={berat.ToString()}&courier={kurir}",
                ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);
            RestSharp.JsonObject obj = (RestSharp.JsonObject)SimpleJson.DeserializeObject(response.Content);
            RestSharp.JsonObject raja0bj = (RestSharp.JsonObject)obj["rajaongkir"];
            RestSharp.JsonArray resultsArray = (RestSharp.JsonArray)raja0bj["results"];
            RestSharp.JsonObject courierInfo = (RestSharp.JsonObject)resultsArray[0];
            RestSharp.JsonArray servicesArray = (RestSharp.JsonArray)courierInfo["costs"];
            foreach (RestSharp.JsonObject service in servicesArray)
            {
                string layanan = (string)courierInfo["name"]; layanan += "-" + (string)service["service"];
                RestSharp.JsonArray detail = (RestSharp.JsonArray)service["cost"];
                RestSharp.JsonObject infoService = (RestSharp.JsonObject)detail[0];
                layanan += " Rp" + (infoService["value"]).ToString();
                layanan += " " + (string)infoService["etd"] + "Hari";
                returnlist.Add(layanan);
            }
            return returnlist;
        }

        public static int GetIdKotaList(string kota)
        {
            int idKota = -1;
            var client = new RestClient("https://api.rajaongkir.com/starter/city");
            var request = new RestRequest(Method.GET);
            request.AddHeader("key", "c31a7ac4eaed9d6d966f5af4cf2aa4b9");

            IRestResponse response = client.Execute(request);
            RestSharp.JsonObject obj = (RestSharp.JsonObject)SimpleJson.DeserializeObject(response.Content);
            RestSharp.JsonObject rajaObj = (RestSharp.JsonObject)obj["rajaongkir"];
            RestSharp.JsonArray cityListArray = (RestSharp.JsonArray)rajaObj["results"];

            foreach (RestSharp.JsonObject city in cityListArray)
            {
                if (((string)city["city_name"]) == kota)
                {
                    idKota = int.Parse((string)city["city_id"]);
                    break;
                }
            }

            return idKota;
        }
    }
}
