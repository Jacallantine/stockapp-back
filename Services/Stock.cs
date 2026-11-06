namespace stocktracking.Services
{
    public class Stock
    {
        public static async Task<string> GetAllStock()
        {

            HttpClient http = new HttpClient();

            var response = await http.GetAsync("https://financialmodelingprep.com/stable/search-name?query=apple&apikey=j1DTyrgOskmyrsHljpmRkakIf09UjtLj");
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);

            return body;
        }
    }
}
