
using Newtonsoft.Json;
using System.Text;
using System.Text.Json;
using Democard.Entities;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Demo Card Maqeta!");

//B_Gpaorders.CreateGpa(tablagpaorder);

  string url = "https://sandbox-api.marqeta.com/v3/gpaorders";
  var byteArray = Encoding.ASCII.GetBytes(("5f19cdd3-f48c-4c9e-8c76-035485bc5847:fc09b65b-e271-44f0-be4c-1d03af59042e"));
  JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

  GpaOrders deposito  = new GpaOrders();
  deposito.user_token           = "jsoriano";
  deposito.amount               = 2;
  deposito.currency_code        = "USD";
  deposito.funding_source_token = "sandbox_program_funding";

  using (var httpClient = new HttpClient())
   {
       httpClient.DefaultRequestHeaders.Authorization =
           new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

       var json = JsonConvert.SerializeObject(deposito);
       var data = new StringContent(json, Encoding.UTF8, "application/json");
       var response = await httpClient.PostAsync(url, data);
       var result = await response.Content.ReadAsStringAsync();
       if (response.IsSuccessStatusCode)
        {
        //Aqui hago el guardado de la tablaa...

      //   B_Kardex.CreateKardex(kardex, "Operation with POST in Maqeta",
      //                                 "Create a Foundig/Deposit Card IN Database y post Api Maqeta",
      //                                 "User=jsoriano currency code=USD sandbox_program_funding",
      //                                 result);
         Console.WriteLine(result);
        Console.ReadLine();
       }


    }

