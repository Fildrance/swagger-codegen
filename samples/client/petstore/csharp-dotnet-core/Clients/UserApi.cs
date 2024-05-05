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
public partial interface IUserApi
{
    /// <summary>
    /// Create user This can only be done by the logged in user.
    /// </summary>
    /// <param name="body">Created user object</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task CreateUser (User body, CancellationToken ct);
    /// <summary>
    /// Creates list of users with given input array 
    /// </summary>
    /// <param name="body">List of user object</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task CreateUsersWithArrayInput (List<User> body, CancellationToken ct);
    /// <summary>
    /// Creates list of users with given input array 
    /// </summary>
    /// <param name="body">List of user object</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task CreateUsersWithListInput (List<User> body, CancellationToken ct);
    /// <summary>
    /// Delete user This can only be done by the logged in user.
    /// </summary>
    /// <param name="username">The name that needs to be deleted</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task DeleteUser (string username, CancellationToken ct);
    /// <summary>
    /// Get user by user name 
    /// </summary>
    /// <param name="username">The name that needs to be fetched. Use user1 for testing.</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>User</returns>
    Task<User> GetUserByName (string username, CancellationToken ct);
    /// <summary>
    /// Logs user into the system 
    /// </summary>
    /// <param name="username">The user name for login</param>
    /// <param name="password">The password for login in clear text</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>string</returns>
    Task<string> LoginUser (string username, string password, CancellationToken ct);
    /// <summary>
    /// Logs out current logged in user session 
    /// </summary>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task LogoutUser (CancellationToken ct);
    /// <summary>
    /// Updated user This can only be done by the logged in user.
    /// </summary>
    /// <param name="username">name that need to be deleted</param>
    /// <param name="body">Updated user object</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task UpdateUser (string username, User body, CancellationToken ct);
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>  
[GeneratedCode("swagger-codegen", "1.0")]
public partial class UserApi : PetShopApiClientBase, IUserApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserApi"/> class.
    /// </summary>
    /// <param name="httpClient"> HttpClient to be used for calls. </param>
    /// <param name="basePath"> Base url to be used for calls. </param>
    public UserApi(HttpClient httpClient, String basePath="http://petstore.swagger.io/v2") : base(httpClient, basePath)
    {
    }

    /// <inheritdoc />     
    public async Task CreateUser(User body, CancellationToken ct)
    {
        
        // verify the required parameter 'body' is set
        if (body == null) throw new PetShopApiException(400, "Missing required parameter 'body' when calling CreateUser");
        

        var path = new StringBuilder("/user");
        
        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path.ToString(), HttpMethod.Post, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task CreateUsersWithArrayInput(List<User> body, CancellationToken ct)
    {
        
        // verify the required parameter 'body' is set
        if (body == null) throw new PetShopApiException(400, "Missing required parameter 'body' when calling CreateUsersWithArrayInput");
        

        var path = new StringBuilder("/user/createWithArray");
        
        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path.ToString(), HttpMethod.Post, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task CreateUsersWithListInput(List<User> body, CancellationToken ct)
    {
        
        // verify the required parameter 'body' is set
        if (body == null) throw new PetShopApiException(400, "Missing required parameter 'body' when calling CreateUsersWithListInput");
        

        var path = new StringBuilder("/user/createWithList");
        
        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path.ToString(), HttpMethod.Post, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task DeleteUser(string username, CancellationToken ct)
    {
        
        // verify the required parameter 'username' is set
        if (username == null) throw new PetShopApiException(400, "Missing required parameter 'username' when calling DeleteUser");
        

        var path = new StringBuilder("/user/{username}");
        path = path.Replace("{username}", ParameterToString(username));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        await CallApi(path.ToString(), HttpMethod.Delete, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task<User> GetUserByName(string username, CancellationToken ct)
    {
        
        // verify the required parameter 'username' is set
        if (username == null) throw new PetShopApiException(400, "Missing required parameter 'username' when calling GetUserByName");
        

        var path = new StringBuilder("/user/{username}");
        path = path.Replace("{username}", ParameterToString(username));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        var response = await CallApi<User>(path.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task<string> LoginUser(string username, string password, CancellationToken ct)
    {
        
        // verify the required parameter 'username' is set
        if (username == null) throw new PetShopApiException(400, "Missing required parameter 'username' when calling LoginUser");
        
        // verify the required parameter 'password' is set
        if (password == null) throw new PetShopApiException(400, "Missing required parameter 'password' when calling LoginUser");
        

        var path = new StringBuilder("/user/login");
        
        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

         if (username != null) queryParams.Add("username", ParameterToString(username)); // query parameter
         if (password != null) queryParams.Add("password", ParameterToString(password)); // query parameter
        
        var response = await CallApi<string>(path.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
        
        return response;
    }

    /// <inheritdoc />     
    public async Task LogoutUser(CancellationToken ct)
    {
        

        var path = new StringBuilder("/user/logout");
        
        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        await CallApi(path.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

    /// <inheritdoc />     
    public async Task UpdateUser(string username, User body, CancellationToken ct)
    {
        
        // verify the required parameter 'username' is set
        if (username == null) throw new PetShopApiException(400, "Missing required parameter 'username' when calling UpdateUser");
        
        // verify the required parameter 'body' is set
        if (body == null) throw new PetShopApiException(400, "Missing required parameter 'body' when calling UpdateUser");
        

        var path = new StringBuilder("/user/{username}");
        path = path.Replace("{username}", ParameterToString(username));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        await CallApi(path.ToString(), HttpMethod.Put, queryParams, postBody, headerParams, formParams, fileParams, ct);
    }

}
