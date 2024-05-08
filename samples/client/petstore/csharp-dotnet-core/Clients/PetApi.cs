using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using PetShop.Models;

namespace PetShop.Clients;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
[GeneratedCode("swagger-codegen", "unset")]
public partial interface IPetApi
{
    /// <summary>
    /// Add a new pet to the store 
    /// </summary>
    /// <param name="body">Pet object that needs to be added to the store</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task AddPet (Pet body, CancellationToken ct);
    /// <summary>
    /// Deletes a pet 
    /// </summary>
    /// <param name="petId">Pet id to delete</param>
    /// <param name="apiKey"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task DeletePet (long? petId, string apiKey, CancellationToken ct);
    /// <summary>
    /// Finds Pets by status Multiple status values can be provided with comma separated strings
    /// </summary>
    /// <param name="status">Status values that need to be considered for filter</param>
    /// <param name="ct"></param>
    /// <returns>List&lt;Pet&gt;</returns>
    Task<List<Pet>> FindPetsByStatus (List<string> status, CancellationToken ct);
    /// <summary>
    /// Finds Pets by tags Multiple tags can be provided with comma separated strings. Use tag1, tag2, tag3 for testing.
    /// </summary>
    /// <param name="tags">Tags to filter by</param>
    /// <param name="ct"></param>
    /// <returns>List&lt;Pet&gt;</returns>
    Task<List<Pet>> FindPetsByTags (List<string> tags, CancellationToken ct);
    /// <summary>
    /// Find pet by ID Returns a pet when ID &lt; 10.  ID &gt; 10 or nonintegers will simulate API error conditions
    /// </summary>
    /// <param name="petId">ID of pet that needs to be fetched</param>
    /// <param name="ct"></param>
    /// <returns>Pet</returns>
    Task<Pet> GetPetById (long? petId, CancellationToken ct);
    /// <summary>
    /// Update an existing pet 
    /// </summary>
    /// <param name="body">Pet object that needs to be added to the store</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task UpdatePet (Pet body, CancellationToken ct);
    /// <summary>
    /// Updates a pet in the store with form data 
    /// </summary>
    /// <param name="petId">ID of pet that needs to be updated</param>
    /// <param name="name"></param>
    /// <param name="status"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task UpdatePetWithForm (string petId, string name, string status, CancellationToken ct);
    /// <summary>
    /// uploads an image 
    /// </summary>
    /// <param name="petId">ID of pet to update</param>
    /// <param name="additionalMetadata"></param>
    /// <param name="file"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task UploadFile (long? petId, string additionalMetadata, byte[] file, CancellationToken ct);
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>  
[GeneratedCode("swagger-codegen", "unset")]
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
        
        var path_ = new StringBuilder("/pet"); 

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post,
                    body: body,   
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task DeletePet(long? petId, string apiKey, CancellationToken ct)
    {
        // verify the required parameter 'petId' is set
        if (petId == null) throw new PetShopApiException(400, "Missing required parameter 'petId' when calling DeletePet");
        
        var path_ = new StringBuilder("/pet/{petId}"); 
        path_ = path_.Replace("{petId}", ParameterToString(petId));

        var headerParams = new Dictionary<string, string>();
        
        if (apiKey != null) headerParams.Add("api_key", ParameterToString(apiKey)); // header parameter
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Delete,
                    headerParams: headerParams,  
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task<List<Pet>> FindPetsByStatus(List<string> status, CancellationToken ct)
    {
        
        var path_ = new StringBuilder("/pet/findByStatus"); 

        var queryParams = new Dictionary<string, string>();
         
        if (status != null) queryParams.Add("status", ParameterToString(status)); // query parameter
        
        var response = await CallApi<List<Pet>>(
                    path_.ToString(), 
                    HttpMethod.Get,
                    queryParams: queryParams,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<List<Pet>> FindPetsByTags(List<string> tags, CancellationToken ct)
    {
        
        var path_ = new StringBuilder("/pet/findByTags"); 

        var queryParams = new Dictionary<string, string>();
         
        if (tags != null) queryParams.Add("tags", ParameterToString(tags)); // query parameter
        
        var response = await CallApi<List<Pet>>(
                    path_.ToString(), 
                    HttpMethod.Get,
                    queryParams: queryParams,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task<Pet> GetPetById(long? petId, CancellationToken ct)
    {
        // verify the required parameter 'petId' is set
        if (petId == null) throw new PetShopApiException(400, "Missing required parameter 'petId' when calling GetPetById");
        
        var path_ = new StringBuilder("/pet/{petId}"); 
        path_ = path_.Replace("{petId}", ParameterToString(petId));

        
        
        var response = await CallApi<Pet>(
                    path_.ToString(), 
                    HttpMethod.Get,  
                    ct: ct
        );
        return response;
    }

    /// <inheritdoc />     
    public async Task UpdatePet(Pet body, CancellationToken ct)
    {
        
        var path_ = new StringBuilder("/pet"); 

        
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Put,
                    body: body,   
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task UpdatePetWithForm(string petId, string name, string status, CancellationToken ct)
    {
        // verify the required parameter 'petId' is set
        if (petId == null) throw new PetShopApiException(400, "Missing required parameter 'petId' when calling UpdatePetWithForm");
        
        var path_ = new StringBuilder("/pet/{petId}"); 
        path_ = path_.Replace("{petId}", ParameterToString(petId));

        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        
        if (name != null) formParams.Add("name", ParameterToString(name)); // form parameter
        if (status != null) formParams.Add("status", ParameterToString(status)); // form parameter
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post, 
                    formParams: formParams,
                    fileParams: fileParams, 
                    ct: ct
        );
    }

    /// <inheritdoc />     
    public async Task UploadFile(long? petId, string additionalMetadata, byte[] file, CancellationToken ct)
    {
        // verify the required parameter 'petId' is set
        if (petId == null) throw new PetShopApiException(400, "Missing required parameter 'petId' when calling UploadFile");
        
        var path_ = new StringBuilder("/pet/{petId}/uploadImage"); 
        path_ = path_.Replace("{petId}", ParameterToString(petId));

        var formParams = new Dictionary<string, string>();
        var fileParams = new Dictionary<string, FileParameter>();
        
        if (additionalMetadata != null) formParams.Add("additionalMetadata", ParameterToString(additionalMetadata)); // form parameter
        if (file != null) fileParams.Add("file", ParameterToFile("file", file));
        
        await CallApi(
                    path_.ToString(), 
                    HttpMethod.Post, 
                    formParams: formParams,
                    fileParams: fileParams, 
                    ct: ct
        );
    }

}
