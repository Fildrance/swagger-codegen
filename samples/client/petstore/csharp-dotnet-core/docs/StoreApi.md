# .StoreApi

All URIs are relative to *http://petstore.swagger.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteOrder**](StoreApi.md#deleteorder) | **Delete** /store/order/{orderId} | Delete purchase order by ID
[**GetInventory**](StoreApi.md#getinventory) | **Get** /store/inventory | Returns pet inventories by status
[**GetOrderById**](StoreApi.md#getorderbyid) | **Get** /store/order/{orderId} | Find purchase order by ID
[**PlaceOrder**](StoreApi.md#placeorder) | **Post** /store/order | Place an order for a pet


<a name="deleteorder"></a>
# **DeleteOrder**
> void DeleteOrder (string orderId, CancellationToken ct)

Delete purchase order by ID

For valid response try integer IDs with value < 1000. Anything above 1000 or nonintegers will generate API errors

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class DeleteOrderExample
    {
        public void main()
        {
            
            var apiInstance = new StoreApi();
            var orderId = orderId_example;  // string | ID of the order that needs to be deleted
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                // Delete purchase order by ID
                apiInstance.DeleteOrder(orderId, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.DeleteOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| ID of the order that needs to be deleted | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinventory"></a>
# **GetInventory**
> Dictionary<string, int?> GetInventory (CancellationToken ct)

Returns pet inventories by status

Returns a map of status codes to quantities

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class GetInventoryExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api_key", "Bearer");

            var apiInstance = new StoreApi();
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                // Returns pet inventories by status
                Dictionary&lt;string, int?&gt; result = apiInstance.GetInventory(ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.GetInventory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

**Dictionary<string, int?>**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderbyid"></a>
# **GetOrderById**
> Order GetOrderById (string orderId, CancellationToken ct)

Find purchase order by ID

For valid response try integer IDs with value <= 5 or > 10. Other values will generated exceptions

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class GetOrderByIdExample
    {
        public void main()
        {
            
            var apiInstance = new StoreApi();
            var orderId = orderId_example;  // string | ID of pet that needs to be fetched
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                // Find purchase order by ID
                Order result = apiInstance.GetOrderById(orderId, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.GetOrderById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| ID of pet that needs to be fetched | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**Order**](Order.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="placeorder"></a>
# **PlaceOrder**
> Order PlaceOrder (Order body, CancellationToken ct)

Place an order for a pet

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class PlaceOrderExample
    {
        public void main()
        {
            
            var apiInstance = new StoreApi();
            var body = new Order(); // Order | order placed for purchasing the pet (optional) 
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                // Place an order for a pet
                Order result = apiInstance.PlaceOrder(body, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StoreApi.PlaceOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Order**](Order.md)| order placed for purchasing the pet | [optional] 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**Order**](Order.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

