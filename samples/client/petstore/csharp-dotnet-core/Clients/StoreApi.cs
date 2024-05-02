using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using PetShop;
using PetShop.Models;

namespace PetShop.Clients;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
[GeneratedCode("swagger-codegen", "1.0")]
public partial interface IStoreApi
{
    /// <summary>
    /// Delete purchase order by ID For valid response try integer IDs with value &lt; 1000. Anything above 1000 or nonintegers will generate API errors
    /// </summary>
    /// <param name="orderId">ID of the order that needs to be deleted</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task DeleteOrder (string orderId, CancellationToken ct);
    /// <summary>
    /// Returns pet inventories by status Returns a map of status codes to quantities
    /// </summary>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>Dictionary&lt;string, int?&gt;</returns>
    Task<Dictionary<string, int?>> GetInventory (CancellationToken ct);
    /// <summary>
    /// Find purchase order by ID For valid response try integer IDs with value &lt;&#x3D; 5 or &gt; 10. Other values will generated exceptions
    /// </summary>
    /// <param name="orderId">ID of pet that needs to be fetched</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>Order</returns>
    Task<Order> GetOrderById (long? orderId, CancellationToken ct);
    /// <summary>
    /// Place an order for a pet 
    /// </summary>
    /// <param name="body">order placed for purchasing the pet</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>Order</returns>
    Task<Order> PlaceOrder (Order body, CancellationToken ct);
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>  
[GeneratedCode("swagger-codegen", "1.0")]
public partial class StoreApi : PetShopApiClientBase, IStoreApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StoreApi"/> class.
    /// </summary>
    /// <param name="httpClient"> HttpClient to be used for calls. </param>
    /// <param name="basePath"> Base url to be used for calls. </param>
    public StoreApi(HttpClient httpClient, String basePath="http://petstore.swagger.io/v2") : base(httpClient, basePath)
    {
    }

    /// <inheritdoc />     
    public async Task DeleteOrder(string orderId, CancellationToken ct)
    {
        
        // verify the required parameter 'orderId' is set
        if (orderId == null) throw new PetShopApiException(400, "Missing required parameter 'orderId' when calling DeleteOrder");
        

        var path = new StringBuilder("/store/order/{orderId}");
        path = path.Replace("{orderId}", ParameterToString(orderId));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        // authentication setting, if any
        string[] authSettings = new string[] {  };

        await CallApi(path.ToString(), HttpMethod.Delete, queryParams, postBody, headerParams, formParams, fileParams, authSettings, ct);
/*
        if (((int)response.StatusCode) >= 400)
            throw new PetShopApiException ((int)response.StatusCode, "Error calling DeleteOrder: " + response.Content, response.Content);
        else if (((int)response.StatusCode) == 0)
            throw new PetShopApiException ((int)response.StatusCode, "Error calling DeleteOrder: " + response.ErrorMessage, response.ErrorMessage);
*/
        
    }

    /// <inheritdoc />     
    public async Task<Dictionary<string, int?>> GetInventory(CancellationToken ct)
    {
        

        var path = new StringBuilder("/store/inventory");
        
        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        // authentication setting, if any
        string[] authSettings = new string[] { "api_key" };

        var response = await CallApi<Dictionary<string, int?>>(path.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings, ct);
/*
        if (((int)response.StatusCode) >= 400)
            throw new PetShopApiException ((int)response.StatusCode, "Error calling GetInventory: " + response.Content, response.Content);
        else if (((int)response.StatusCode) == 0)
            throw new PetShopApiException ((int)response.StatusCode, "Error calling GetInventory: " + response.ErrorMessage, response.ErrorMessage);
*/
        return response;
    }

    /// <inheritdoc />     
    public async Task<Order> GetOrderById(long? orderId, CancellationToken ct)
    {
        
        // verify the required parameter 'orderId' is set
        if (orderId == null) throw new PetShopApiException(400, "Missing required parameter 'orderId' when calling GetOrderById");
        

        var path = new StringBuilder("/store/order/{orderId}");
        path = path.Replace("{orderId}", ParameterToString(orderId));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        // authentication setting, if any
        string[] authSettings = new string[] {  };

        var response = await CallApi<Order>(path.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings, ct);
/*
        if (((int)response.StatusCode) >= 400)
            throw new PetShopApiException ((int)response.StatusCode, "Error calling GetOrderById: " + response.Content, response.Content);
        else if (((int)response.StatusCode) == 0)
            throw new PetShopApiException ((int)response.StatusCode, "Error calling GetOrderById: " + response.ErrorMessage, response.ErrorMessage);
*/
        return response;
    }

    /// <inheritdoc />     
    public async Task<Order> PlaceOrder(Order body, CancellationToken ct)
    {
        
        // verify the required parameter 'body' is set
        if (body == null) throw new PetShopApiException(400, "Missing required parameter 'body' when calling PlaceOrder");
        

        var path = new StringBuilder("/store/order");
        
        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        // authentication setting, if any
        string[] authSettings = new string[] {  };

        var response = await CallApi<Order>(path.ToString(), HttpMethod.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings, ct);
/*
        if (((int)response.StatusCode) >= 400)
            throw new PetShopApiException ((int)response.StatusCode, "Error calling PlaceOrder: " + response.Content, response.Content);
        else if (((int)response.StatusCode) == 0)
            throw new PetShopApiException ((int)response.StatusCode, "Error calling PlaceOrder: " + response.ErrorMessage, response.ErrorMessage);
*/
        return response;
    }

}
