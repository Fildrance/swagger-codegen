using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using IO.Swagger.Models;

namespace IO.Swagger.Clients
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    [GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
    public partial interface IStoreApi
    {
        /// <summary>
        /// Delete purchase order by ID For valid response try integer IDs with value &lt; 1000. Anything above 1000 or nonintegers will generate API errors
        /// </summary>
        /// <param name="orderId">ID of the order that needs to be deleted</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task DeleteOrder (string orderId, CancellationToken ct);
        /// <summary>
        /// Returns pet inventories by status Returns a map of status codes to quantities
        /// </summary>
        /// <param name="ct"></param>
        /// <returns>Dictionary&lt;string, int?&gt;</returns>
        Task<Dictionary<string, int?>> GetInventory (CancellationToken ct);
        /// <summary>
        /// Find purchase order by ID For valid response try integer IDs with value &lt;&#x3D; 5 or &gt; 10. Other values will generated exceptions
        /// </summary>
        /// <param name="orderId">ID of pet that needs to be fetched</param>
        /// <param name="ct"></param>
        /// <returns>Order</returns>
        Task<Order> GetOrderById (long? orderId, CancellationToken ct);
        /// <summary>
        /// Place an order for a pet 
        /// </summary>
        /// <param name="body">order placed for purchasing the pet</param>
        /// <param name="ct"></param>
        /// <returns>Order</returns>
        Task<Order> PlaceOrder (Order body, CancellationToken ct);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>  
    [GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
    public partial class StoreApi : IOSwaggerClientApiClientBase, IStoreApi
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
            if (orderId == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'orderId' when calling DeleteOrder");
            
            var path_ = new StringBuilder("/store/order/{orderId}"); 
            path_ = path_.Replace("{orderId}", ParameterToString(orderId));

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Delete,  
                        ct: ct
            );
        }

        /// <inheritdoc />     
        public async Task<Dictionary<string, int?>> GetInventory(CancellationToken ct)
        {
            
            var path_ = new StringBuilder("/store/inventory"); 

            
        
            var response = await CallApi<Dictionary<string, int?>>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<Order> GetOrderById(long? orderId, CancellationToken ct)
        {
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'orderId' when calling GetOrderById");
            
            var path_ = new StringBuilder("/store/order/{orderId}"); 
            path_ = path_.Replace("{orderId}", ParameterToString(orderId));

            
        
            var response = await CallApi<Order>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<Order> PlaceOrder(Order body, CancellationToken ct)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'body' when calling PlaceOrder");
            
            var path_ = new StringBuilder("/store/order"); 

            
        
            var response = await CallApi<Order>(
                        path_.ToString(), 
                        HttpMethod.Post,
                        body: body,   
                        ct: ct
            );
            return response;
        }

    }
}