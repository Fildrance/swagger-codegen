# PetShop.Clients.UserApi

All URIs are relative to *http://petstore.swagger.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateUser**](UserApi.md#createuser) | **POST** /user | Create user
[**CreateUsersWithArrayInput**](UserApi.md#createuserswitharrayinput) | **POST** /user/createWithArray | Creates list of users with given input array
[**CreateUsersWithListInput**](UserApi.md#createuserswithlistinput) | **POST** /user/createWithList | Creates list of users with given input array
[**DeleteUser**](UserApi.md#deleteuser) | **DELETE** /user/{username} | Delete user
[**GetUserByName**](UserApi.md#getuserbyname) | **GET** /user/{username} | Get user by user name
[**LoginUser**](UserApi.md#loginuser) | **GET** /user/login | Logs user into the system
[**LogoutUser**](UserApi.md#logoutuser) | **GET** /user/logout | Logs out current logged in user session
[**UpdateUser**](UserApi.md#updateuser) | **PUT** /user/{username} | Updated user


<a name="createuser"></a>
# **CreateUser**
> void CreateUser (User body, CancellationToken ct)

Create user

This can only be done by the logged in user.

### Example
```csharp
using System;
using System.Diagnostics;
using PetShop.Clients;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class CreateUserExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var body = new User(); // User | Created user object
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                // Create user
                apiInstance.CreateUser(body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.CreateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**User**](User.md)| Created user object | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createuserswitharrayinput"></a>
# **CreateUsersWithArrayInput**
> void CreateUsersWithArrayInput (List<User> body, CancellationToken ct)

Creates list of users with given input array



### Example
```csharp
using System;
using System.Diagnostics;
using PetShop.Clients;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class CreateUsersWithArrayInputExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var body = new List<User>(); // List<User> | List of user object
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                // Creates list of users with given input array
                apiInstance.CreateUsersWithArrayInput(body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.CreateUsersWithArrayInput: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List<User>**](User.md)| List of user object | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createuserswithlistinput"></a>
# **CreateUsersWithListInput**
> void CreateUsersWithListInput (List<User> body, CancellationToken ct)

Creates list of users with given input array



### Example
```csharp
using System;
using System.Diagnostics;
using PetShop.Clients;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class CreateUsersWithListInputExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var body = new List<User>(); // List<User> | List of user object
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                // Creates list of users with given input array
                apiInstance.CreateUsersWithListInput(body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.CreateUsersWithListInput: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List<User>**](User.md)| List of user object | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuser"></a>
# **DeleteUser**
> void DeleteUser (string username, CancellationToken ct)

Delete user

This can only be done by the logged in user.

### Example
```csharp
using System;
using System.Diagnostics;
using PetShop.Clients;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class DeleteUserExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var username = username_example;  // string | The name that needs to be deleted
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                // Delete user
                apiInstance.DeleteUser(username, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.DeleteUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The name that needs to be deleted | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserbyname"></a>
# **GetUserByName**
> User GetUserByName (string username, CancellationToken ct)

Get user by user name



### Example
```csharp
using System;
using System.Diagnostics;
using PetShop.Clients;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class GetUserByNameExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var username = username_example;  // string | The name that needs to be fetched. Use user1 for testing.
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                // Get user by user name
                User result = apiInstance.GetUserByName(username, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUserByName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The name that needs to be fetched. Use user1 for testing. | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loginuser"></a>
# **LoginUser**
> string LoginUser (string username, string password, CancellationToken ct)

Logs user into the system



### Example
```csharp
using System;
using System.Diagnostics;
using PetShop.Clients;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class LoginUserExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var username = username_example;  // string | The user name for login
            var password = password_example;  // string | The password for login in clear text
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                // Logs user into the system
                string result = apiInstance.LoginUser(username, password, ct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.LoginUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The user name for login | 
 **password** | **string**| The password for login in clear text | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logoutuser"></a>
# **LogoutUser**
> void LogoutUser (CancellationToken ct)

Logs out current logged in user session



### Example
```csharp
using System;
using System.Diagnostics;
using PetShop.Clients;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class LogoutUserExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                // Logs out current logged in user session
                apiInstance.LogoutUser(ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.LogoutUser: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuser"></a>
# **UpdateUser**
> void UpdateUser (string username, User body, CancellationToken ct)

Updated user

This can only be done by the logged in user.

### Example
```csharp
using System;
using System.Diagnostics;
using PetShop.Clients;
using PetShop;
using PetShop.Models;

namespace Example
{
    public class UpdateUserExample
    {
        public void main()
        {
            
            var apiInstance = new UserApi();
            var username = username_example;  // string | name that need to be deleted
            var body = new User(); // User | Updated user object
            var ct = new CancellationToken(); // CancellationToken |  (optional) 

            try
            {
                // Updated user
                apiInstance.UpdateUser(username, body, ct);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UpdateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| name that need to be deleted | 
 **body** | [**User**](User.md)| Updated user object | 
 **ct** | [**CancellationToken**](.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

