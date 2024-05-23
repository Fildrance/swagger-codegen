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
    public partial interface IUserApi
    {
        /// <summary>
        /// Create user This can only be done by the logged in user.
        /// </summary>
        /// <param name="body">Created user object</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task CreateUser (User body, CancellationToken ct);
        /// <summary>
        /// Creates list of users with given input array 
        /// </summary>
        /// <param name="body">List of user object</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task CreateUsersWithArrayInput (List<User> body, CancellationToken ct);
        /// <summary>
        /// Creates list of users with given input array 
        /// </summary>
        /// <param name="body">List of user object</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task CreateUsersWithListInput (List<User> body, CancellationToken ct);
        /// <summary>
        /// Delete user This can only be done by the logged in user.
        /// </summary>
        /// <param name="username">The name that needs to be deleted</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task DeleteUser (string username, CancellationToken ct);
        /// <summary>
        /// Get user by user name 
        /// </summary>
        /// <param name="username">The name that needs to be fetched. Use user1 for testing. </param>
        /// <param name="ct"></param>
        /// <returns>User</returns>
        Task<User> GetUserByName (string username, CancellationToken ct);
        /// <summary>
        /// Logs user into the system 
        /// </summary>
        /// <param name="username">The user name for login</param>
        /// <param name="password">The password for login in clear text</param>
        /// <param name="ct"></param>
        /// <returns>string</returns>
        Task<string> LoginUser (string username, string password, CancellationToken ct);
        /// <summary>
        /// Logs out current logged in user session 
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task LogoutUser (CancellationToken ct);
        /// <summary>
        /// Updated user This can only be done by the logged in user.
        /// </summary>
        /// <param name="body">Updated user object</param>
        /// <param name="username">name that need to be deleted</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task UpdateUser (User body, string username, CancellationToken ct);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>  
    [GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
    public partial class UserApi : IOSwaggerClientApiClientBase, IUserApi
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
            if (body == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'body' when calling CreateUser");
            
            var path_ = new StringBuilder("/user"); 

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Post,
                        body: body,   
                        ct: ct
            );
        }

        /// <inheritdoc />     
        public async Task CreateUsersWithArrayInput(List<User> body, CancellationToken ct)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'body' when calling CreateUsersWithArrayInput");
            
            var path_ = new StringBuilder("/user/createWithArray"); 

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Post,
                        body: body,   
                        ct: ct
            );
        }

        /// <inheritdoc />     
        public async Task CreateUsersWithListInput(List<User> body, CancellationToken ct)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'body' when calling CreateUsersWithListInput");
            
            var path_ = new StringBuilder("/user/createWithList"); 

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Post,
                        body: body,   
                        ct: ct
            );
        }

        /// <inheritdoc />     
        public async Task DeleteUser(string username, CancellationToken ct)
        {
            // verify the required parameter 'username' is set
            if (username == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'username' when calling DeleteUser");
            
            var path_ = new StringBuilder("/user/{username}"); 
            path_ = path_.Replace("{username}", ParameterToString(username));

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Delete,  
                        ct: ct
            );
        }

        /// <inheritdoc />     
        public async Task<User> GetUserByName(string username, CancellationToken ct)
        {
            // verify the required parameter 'username' is set
            if (username == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'username' when calling GetUserByName");
            
            var path_ = new StringBuilder("/user/{username}"); 
            path_ = path_.Replace("{username}", ParameterToString(username));

            
        
            var response = await CallApi<User>(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task<string> LoginUser(string username, string password, CancellationToken ct)
        {
            // verify the required parameter 'username' is set
            if (username == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'username' when calling LoginUser");
            // verify the required parameter 'password' is set
            if (password == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'password' when calling LoginUser");
            
            var path_ = new StringBuilder("/user/login"); 

            var queryParams = new Dictionary<string, string>();
             
            if (username != null) queryParams.Add("username", ParameterToString(username)); // query parameter 
            if (password != null) queryParams.Add("password", ParameterToString(password)); // query parameter
        
            var response = await CallApi<string>(
                        path_.ToString(), 
                        HttpMethod.Get,
                        queryParams: queryParams,  
                        ct: ct
            );
            return response;
        }

        /// <inheritdoc />     
        public async Task LogoutUser(CancellationToken ct)
        {
            
            var path_ = new StringBuilder("/user/logout"); 

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Get,  
                        ct: ct
            );
        }

        /// <inheritdoc />     
        public async Task UpdateUser(User body, string username, CancellationToken ct)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'body' when calling UpdateUser");
            // verify the required parameter 'username' is set
            if (username == null) throw new IOSwaggerClientApiException(400, "Missing required parameter 'username' when calling UpdateUser");
            
            var path_ = new StringBuilder("/user/{username}"); 
            path_ = path_.Replace("{username}", ParameterToString(username));

            
        
            await CallApi(
                        path_.ToString(), 
                        HttpMethod.Put,
                        body: body,   
                        ct: ct
            );
        }

    }
}