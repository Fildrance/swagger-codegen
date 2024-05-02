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
public partial interface IPetApi
{
    /// <summary>
    /// Add a new pet to the store 
    /// </summary>
    /// <param name="body">Pet object that needs to be added to the store</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task AddPet (Pet body, CancellationToken ct);
    /// <summary>
    /// Deletes a pet 
    /// </summary>
    /// <param name="petId">Pet id to delete</param>
    /// <param name="apiKey"></param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task DeletePet (long? petId, string apiKey, CancellationToken ct);
    /// <summary>
    /// Finds Pets by status Multiple status values can be provided with comma separated strings
    /// </summary>
    /// <param name="status">Status values that need to be considered for filter</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;Pet&gt;</returns>
    Task<List<Pet>> FindPetsByStatus (List<string> status, CancellationToken ct);
    /// <summary>
    /// Finds Pets by tags Multiple tags can be provided with comma separated strings. Use tag1, tag2, tag3 for testing.
    /// </summary>
    /// <param name="tags">Tags to filter by</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>List&lt;Pet&gt;</returns>
    Task<List<Pet>> FindPetsByTags (List<string> tags, CancellationToken ct);
    /// <summary>
    /// Find pet by ID Returns a single pet
    /// </summary>
    /// <param name="petId">ID of pet to return</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>Pet</returns>
    Task<Pet> GetPetById (long? petId, CancellationToken ct);
    /// <summary>
    /// Update an existing pet 
    /// </summary>
    /// <param name="body">Pet object that needs to be added to the store</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task UpdatePet (Pet body, CancellationToken ct);
    /// <summary>
    /// Updates a pet in the store with form data 
    /// </summary>
    /// <param name="petId">ID of pet that needs to be updated</param>
    /// <param name="name">Updated name of the pet</param>
    /// <param name="status">Updated status of the pet</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns></returns>
    Task UpdatePetWithForm (long? petId, string name, string status, CancellationToken ct);
    /// <summary>
    /// uploads an image 
    /// </summary>
    /// <param name="petId">ID of pet to update</param>
    /// <param name="additionalMetadata">Additional data to pass to server</param>
    /// <param name="_file">file to upload</param>
    /// <param name="ct"></param>
    /// <param name="ct">Operation cancellation token. </param>
    /// <returns>ApiResponse</returns>
    Task<ApiResponse> UploadFile (long? petId, string additionalMetadata, System.IO.Stream _file, CancellationToken ct);
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>  
[GeneratedCode("swagger-codegen", "1.0")]
public partial class PetApi : PetShopApiClientBase, IPetApi
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PetApi"/> class.
    /// </summary>
    /// <param name="httpClient"> HttpClient to be used for calls. </param>
    /// <param name="basePath"> Base url to be used for calls. </param>
    public PetApi(HttpClient httpClient, String basePath="http://petstore.swagger.io/v2") : base(httpClient, basePath)
    {
    }

    /// <inheritdoc />     
    public async Task AddPet(Pet body, CancellationToken ct)
    {
        
        // verify the required parameter 'body' is set
        if (body == null) throw new PetShopApiException(400, "Missing required parameter 'body' when calling AddPet");
        

        var path = new StringBuilder("/pet");
        
        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        // authentication setting, if any
        string[] authSettings = new string[] { "petstore_auth" };

        await CallApi(path.ToString(), HttpMethod.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings, ct);
/*
        if (((int)response.StatusCode) >= 400)
            throw new PetShopApiException ((int)response.StatusCode, "Error calling AddPet: " + response.Content, response.Content);
        else if (((int)response.StatusCode) == 0)
            throw new PetShopApiException ((int)response.StatusCode, "Error calling AddPet: " + response.ErrorMessage, response.ErrorMessage);
*/
        
    }

    /// <inheritdoc />     
    public async Task DeletePet(long? petId, string apiKey, CancellationToken ct)
    {
        
        // verify the required parameter 'petId' is set
        if (petId == null) throw new PetShopApiException(400, "Missing required parameter 'petId' when calling DeletePet");
        

        var path = new StringBuilder("/pet/{petId}");
        path = path.Replace("{petId}", ParameterToString(petId));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

         if (apiKey != null) headerParams.Add("api_key", ParameterToString(apiKey)); // header parameter
        
        // authentication setting, if any
        string[] authSettings = new string[] { "petstore_auth" };

        await CallApi(path.ToString(), HttpMethod.Delete, queryParams, postBody, headerParams, formParams, fileParams, authSettings, ct);
/*
        if (((int)response.StatusCode) >= 400)
            throw new PetShopApiException ((int)response.StatusCode, "Error calling DeletePet: " + response.Content, response.Content);
        else if (((int)response.StatusCode) == 0)
            throw new PetShopApiException ((int)response.StatusCode, "Error calling DeletePet: " + response.ErrorMessage, response.ErrorMessage);
*/
        
    }

    /// <inheritdoc />     
    public async Task<List<Pet>> FindPetsByStatus(List<string> status, CancellationToken ct)
    {
        
        // verify the required parameter 'status' is set
        if (status == null) throw new PetShopApiException(400, "Missing required parameter 'status' when calling FindPetsByStatus");
        

        var path = new StringBuilder("/pet/findByStatus");
        
        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

         if (status != null) queryParams.Add("status", ParameterToString(status)); // query parameter
        
        // authentication setting, if any
        string[] authSettings = new string[] { "petstore_auth" };

        var response = await CallApi<List<Pet>>(path.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings, ct);
/*
        if (((int)response.StatusCode) >= 400)
            throw new PetShopApiException ((int)response.StatusCode, "Error calling FindPetsByStatus: " + response.Content, response.Content);
        else if (((int)response.StatusCode) == 0)
            throw new PetShopApiException ((int)response.StatusCode, "Error calling FindPetsByStatus: " + response.ErrorMessage, response.ErrorMessage);
*/
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<Pet>> FindPetsByTags(List<string> tags, CancellationToken ct)
    {
        
        // verify the required parameter 'tags' is set
        if (tags == null) throw new PetShopApiException(400, "Missing required parameter 'tags' when calling FindPetsByTags");
        

        var path = new StringBuilder("/pet/findByTags");
        
        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

         if (tags != null) queryParams.Add("tags", ParameterToString(tags)); // query parameter
        
        // authentication setting, if any
        string[] authSettings = new string[] { "petstore_auth" };

        var response = await CallApi<List<Pet>>(path.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings, ct);
/*
        if (((int)response.StatusCode) >= 400)
            throw new PetShopApiException ((int)response.StatusCode, "Error calling FindPetsByTags: " + response.Content, response.Content);
        else if (((int)response.StatusCode) == 0)
            throw new PetShopApiException ((int)response.StatusCode, "Error calling FindPetsByTags: " + response.ErrorMessage, response.ErrorMessage);
*/
        return response;
    }

    /// <inheritdoc />     
    public async Task<Pet> GetPetById(long? petId, CancellationToken ct)
    {
        
        // verify the required parameter 'petId' is set
        if (petId == null) throw new PetShopApiException(400, "Missing required parameter 'petId' when calling GetPetById");
        

        var path = new StringBuilder("/pet/{petId}");
        path = path.Replace("{petId}", ParameterToString(petId));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        
        // authentication setting, if any
        string[] authSettings = new string[] { "api_key" };

        var response = await CallApi<Pet>(path.ToString(), HttpMethod.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings, ct);
/*
        if (((int)response.StatusCode) >= 400)
            throw new PetShopApiException ((int)response.StatusCode, "Error calling GetPetById: " + response.Content, response.Content);
        else if (((int)response.StatusCode) == 0)
            throw new PetShopApiException ((int)response.StatusCode, "Error calling GetPetById: " + response.ErrorMessage, response.ErrorMessage);
*/
        return response;
    }

    /// <inheritdoc />     
    public async Task UpdatePet(Pet body, CancellationToken ct)
    {
        
        // verify the required parameter 'body' is set
        if (body == null) throw new PetShopApiException(400, "Missing required parameter 'body' when calling UpdatePet");
        

        var path = new StringBuilder("/pet");
        
        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        postBody = body; // http body (model) parameter

        // authentication setting, if any
        string[] authSettings = new string[] { "petstore_auth" };

        await CallApi(path.ToString(), HttpMethod.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings, ct);
/*
        if (((int)response.StatusCode) >= 400)
            throw new PetShopApiException ((int)response.StatusCode, "Error calling UpdatePet: " + response.Content, response.Content);
        else if (((int)response.StatusCode) == 0)
            throw new PetShopApiException ((int)response.StatusCode, "Error calling UpdatePet: " + response.ErrorMessage, response.ErrorMessage);
*/
        
    }

    /// <inheritdoc />     
    public async Task UpdatePetWithForm(long? petId, string name, string status, CancellationToken ct)
    {
        
        // verify the required parameter 'petId' is set
        if (petId == null) throw new PetShopApiException(400, "Missing required parameter 'petId' when calling UpdatePetWithForm");
        

        var path = new StringBuilder("/pet/{petId}");
        path = path.Replace("{petId}", ParameterToString(petId));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        if (name != null) formParams.Add("name", ParameterToString(name)); // form parameter
        if (status != null) formParams.Add("status", ParameterToString(status)); // form parameter
        
        // authentication setting, if any
        string[] authSettings = new string[] { "petstore_auth" };

        await CallApi(path.ToString(), HttpMethod.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings, ct);
/*
        if (((int)response.StatusCode) >= 400)
            throw new PetShopApiException ((int)response.StatusCode, "Error calling UpdatePetWithForm: " + response.Content, response.Content);
        else if (((int)response.StatusCode) == 0)
            throw new PetShopApiException ((int)response.StatusCode, "Error calling UpdatePetWithForm: " + response.ErrorMessage, response.ErrorMessage);
*/
        
    }

    /// <inheritdoc />     
    public async Task<ApiResponse> UploadFile(long? petId, string additionalMetadata, System.IO.Stream _file, CancellationToken ct)
    {
        
        // verify the required parameter 'petId' is set
        if (petId == null) throw new PetShopApiException(400, "Missing required parameter 'petId' when calling UploadFile");
        

        var path = new StringBuilder("/pet/{petId}/uploadImage");
        path = path.Replace("{petId}", ParameterToString(petId));

        var queryParams = new Dictionary<string, string>();
        var headerParams = new Dictionary<string, string>();
        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        object postBody = null;

        if (additionalMetadata != null) formParams.Add("additionalMetadata", ParameterToString(additionalMetadata)); // form parameter
        if (_file != null) fileParams.Add("file", ParameterToFile("file", _file));
        
        // authentication setting, if any
        string[] authSettings = new string[] { "petstore_auth" };

        var response = await CallApi<ApiResponse>(path.ToString(), HttpMethod.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings, ct);
/*
        if (((int)response.StatusCode) >= 400)
            throw new PetShopApiException ((int)response.StatusCode, "Error calling UploadFile: " + response.Content, response.Content);
        else if (((int)response.StatusCode) == 0)
            throw new PetShopApiException ((int)response.StatusCode, "Error calling UploadFile: " + response.ErrorMessage, response.ErrorMessage);
*/
        return response;
    }

}
