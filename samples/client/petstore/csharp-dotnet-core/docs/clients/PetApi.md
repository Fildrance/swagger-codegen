# .PetApi

All URIs are relative to *http://petstore.swagger.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPet**](PetApi.md#addpet) | **Post** /pet | Add a new pet to the store
[**DeletePet**](PetApi.md#deletepet) | **Delete** /pet/{petId} | Deletes a pet
[**FindPetsByStatus**](PetApi.md#findpetsbystatus) | **Get** /pet/findByStatus | Finds Pets by status
[**FindPetsByTags**](PetApi.md#findpetsbytags) | **Get** /pet/findByTags | Finds Pets by tags
[**GetPetById**](PetApi.md#getpetbyid) | **Get** /pet/{petId} | Find pet by ID
[**UpdatePet**](PetApi.md#updatepet) | **Put** /pet | Update an existing pet
[**UpdatePetWithForm**](PetApi.md#updatepetwithform) | **Post** /pet/{petId} | Updates a pet in the store with form data
[**UploadFile**](PetApi.md#uploadfile) | **Post** /pet/{petId}/uploadImage | uploads an image


<a name="addpet"></a>
# **AddPet**
> void AddPet (Pet body, CancellationToken ct)

Add a new pet to the store

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using IO.Swagger.Client;
using IO.Swagger.Models;

namespace Example
{
    public class AddPetExample
    {
        public void main()
        {
            var apiInstance = new PetApi(new HttpClient(), "http://my-service.srv");
            var body = new Pet(); // Pet | Pet object that needs to be added to the store
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                // Add a new pet to the store
                apiInstance.AddPet(body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PetApi.AddPet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Pet**](Pet.md)| Pet object that needs to be added to the store | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepet"></a>
# **DeletePet**
> void DeletePet (long? petId, string apiKey, CancellationToken ct)

Deletes a pet

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using IO.Swagger.Client;
using IO.Swagger.Models;

namespace Example
{
    public class DeletePetExample
    {
        public void main()
        {
            var apiInstance = new PetApi(new HttpClient(), "http://my-service.srv");
            var petId = 789;  // long? | Pet id to delete
            var apiKey = apiKey_example;  // string |  (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                // Deletes a pet
                apiInstance.DeletePet(petId, apiKey, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PetApi.DeletePet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **petId** | **long?**| Pet id to delete | 
 **apiKey** | **string**|  | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findpetsbystatus"></a>
# **FindPetsByStatus**
> List<Pet> FindPetsByStatus (List<string> status, CancellationToken ct)

Finds Pets by status

Multiple status values can be provided with comma separated strings

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using IO.Swagger.Client;
using IO.Swagger.Models;

namespace Example
{
    public class FindPetsByStatusExample
    {
        public void main()
        {
            var apiInstance = new PetApi(new HttpClient(), "http://my-service.srv");
            var status = new List<string>(); // List<string> | Status values that need to be considered for filter
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                // Finds Pets by status
                List&lt;Pet&gt; result = apiInstance.FindPetsByStatus(status, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PetApi.FindPetsByStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **status** | [**List<string>**](string.md)| Status values that need to be considered for filter | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<Pet>**](Pet.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findpetsbytags"></a>
# **FindPetsByTags**
> List<Pet> FindPetsByTags (List<string> tags, CancellationToken ct)

Finds Pets by tags

Multiple tags can be provided with comma separated strings. Use tag1, tag2, tag3 for testing.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using IO.Swagger.Client;
using IO.Swagger.Models;

namespace Example
{
    public class FindPetsByTagsExample
    {
        public void main()
        {
            var apiInstance = new PetApi(new HttpClient(), "http://my-service.srv");
            var tags = new List<string>(); // List<string> | Tags to filter by
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                // Finds Pets by tags
                List&lt;Pet&gt; result = apiInstance.FindPetsByTags(tags, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PetApi.FindPetsByTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tags** | [**List<string>**](string.md)| Tags to filter by | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**List<Pet>**](Pet.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpetbyid"></a>
# **GetPetById**
> Pet GetPetById (long? petId, CancellationToken ct)

Find pet by ID

Returns a single pet

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using IO.Swagger.Client;
using IO.Swagger.Models;

namespace Example
{
    public class GetPetByIdExample
    {
        public void main()
        {
            var apiInstance = new PetApi(new HttpClient(), "http://my-service.srv");
            var petId = 789;  // long? | ID of pet to return
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                // Find pet by ID
                Pet result = apiInstance.GetPetById(petId, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PetApi.GetPetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **petId** | **long?**| ID of pet to return | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**Pet**](Pet.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepet"></a>
# **UpdatePet**
> void UpdatePet (Pet body, CancellationToken ct)

Update an existing pet

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using IO.Swagger.Client;
using IO.Swagger.Models;

namespace Example
{
    public class UpdatePetExample
    {
        public void main()
        {
            var apiInstance = new PetApi(new HttpClient(), "http://my-service.srv");
            var body = new Pet(); // Pet | Pet object that needs to be added to the store
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                // Update an existing pet
                apiInstance.UpdatePet(body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PetApi.UpdatePet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Pet**](Pet.md)| Pet object that needs to be added to the store | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepetwithform"></a>
# **UpdatePetWithForm**
> void UpdatePetWithForm (long? petId, string name, string status, CancellationToken ct)

Updates a pet in the store with form data

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using IO.Swagger.Client;
using IO.Swagger.Models;

namespace Example
{
    public class UpdatePetWithFormExample
    {
        public void main()
        {
            var apiInstance = new PetApi(new HttpClient(), "http://my-service.srv");
            var petId = 789;  // long? | ID of pet that needs to be updated
            var name = name_example;  // string |  (optional) 
            var status = status_example;  // string |  (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                // Updates a pet in the store with form data
                apiInstance.UpdatePetWithForm(petId, name, status, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PetApi.UpdatePetWithForm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **petId** | **long?**| ID of pet that needs to be updated | 
 **name** | **string**|  | [optional] 
 **status** | **string**|  | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadfile"></a>
# **UploadFile**
> ModelApiResponse UploadFile (long? petId, string additionalMetadata, byte[] file, CancellationToken ct)

uploads an image

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using IO.Swagger.Client;
using IO.Swagger.Models;

namespace Example
{
    public class UploadFileExample
    {
        public void main()
        {
            var apiInstance = new PetApi(new HttpClient(), "http://my-service.srv");
            var petId = 789;  // long? | ID of pet to update
            var additionalMetadata = additionalMetadata_example;  // string |  (optional) 
            var file = file_example;  // byte[] |  (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                // uploads an image
                ModelApiResponse result = apiInstance.UploadFile(petId, additionalMetadata, file, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PetApi.UploadFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **petId** | **long?**| ID of pet to update | 
 **additionalMetadata** | **string**|  | [optional] 
 **file** | **byte[]****byte[]**|  | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**ModelApiResponse**](ModelApiResponse.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

