using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Globalization;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace PetShop;

/// <summary>
/// Base type for API client is mainly responsible for making the HTTP call to the API.
/// </summary>
[GeneratedCode("swagger-codegen", "1.0")]
public abstract class PetShopApiClientBase
{
    protected readonly HttpClient _httpClient;
    protected readonly string _basePath;
    protected readonly JsonSerializerOptions _options;

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiClient" /> class.
    /// </summary>
    /// <param name="httpClient">Client for making http calls.</param>
    /// <param name="basePath">The base path.</param>
    /// <param name="options">Serialization settings.</param>
    protected PetShopApiClientBase(HttpClient httpClient, string basePath, JsonSerializerOptions options = null)
    {
        _httpClient = httpClient;
        _basePath = basePath;
        _options = options ?? JsonSerializerOptions.Default;
    }

    protected virtual string ContentType => "application/json-patch+json";
    protected virtual string Accept => "application/json";

    /// <summary>
    /// Makes the HTTP request.
    /// </summary>
    /// <param name="path">URL path.</param>
    /// <param name="method">HTTP method.</param>
    /// <param name="queryParams">Query parameters.</param>
    /// <param name="body">Object to be serialized for http request body.</param>
    /// <param name="headerParams">Header parameters.</param>
    /// <param name="formParams">Form parameters.</param>
    /// <param name="fileParams">File parameters.</param>
    /// <param name="authSettings">Authentication settings.</param>
    /// <param name="ct">Operation cancellation token.</param>
    /// <returns>Result of request.</returns>
    public async Task<T> CallApi<T>(
        string path, 
        HttpMethod method, 
        Dictionary<string, string> queryParams, 
        Object body,
        Dictionary<string, string> headerParams, 
        Dictionary<string, string> formParams, 
        Dictionary<string, FileParameter> fileParams, 
        string[] authSettings,
        CancellationToken ct
    )
    {
        UpdateParamsForAuth(queryParams, headerParams, authSettings);
    
        using (var request = new HttpRequestMessage())
        {
            PrepareRequest(path, method, queryParams, body, headerParams, formParams, fileParams, request);
            HttpResponseMessage response = null;
            try
            {
                response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, ct).ConfigureAwait(false);
    
                var headers = new Dictionary<string, IEnumerable<string>>();
                foreach (var item in response.Headers)
                    headers[item.Key] = item.Value;
                if (response.Content != null && response.Content.Headers != null)
                {
                    foreach (var item in response.Content.Headers)
                    {
                        headers[item.Key] = item.Value;
                    }
                }
        
                var status = (int)response.StatusCode;
                if (status == 200)
                {
                    var objectResponse = await ReadObjectResponseAsync<T>(response, headers, ct).ConfigureAwait(false);
                    if (objectResponse.Object == null)
                    {
                        throw new PetShopApiException(status, "Response was null which was not expected.", objectResponse.Text, headers, null);
                    }
                    return objectResponse.Object;
                }
                else
                {
                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync(ct).ConfigureAwait(false);
                    throw new PetShopApiException(status, "The HTTP status code of the response was not expected (" + status + ").", responseData, headers, null);
                }
            }
            finally
            {
                response?.Dispose();
            }
        }
    }

    /// <summary>
    /// Makes the HTTP request.
    /// </summary>
    /// <param name="path">URL path.</param>
    /// <param name="method">HTTP method.</param>
    /// <param name="queryParams">Query parameters.</param>
    /// <param name="body">Object to be serialized for http request body.</param>
    /// <param name="headerParams">Header parameters.</param>
    /// <param name="formParams">Form parameters.</param>
    /// <param name="fileParams">File parameters.</param>
    /// <param name="authSettings">Authentication settings.</param>
    /// <param name="ct">Operation cancellation token.</param>
    /// <returns>Result of request.</returns>
    public async Task CallApi(
        String path, 
        HttpMethod method, 
        Dictionary<String, String> queryParams, 
        Object body,
        Dictionary<String, String> headerParams, 
        Dictionary<String, String> formParams, 
        Dictionary<String, FileParameter> fileParams, 
        String[] authSettings,
        CancellationToken ct
    )
    {
        UpdateParamsForAuth(queryParams, headerParams, authSettings);
    
        using (var request = new HttpRequestMessage())
        {
            PrepareRequest(path, method, queryParams, body, headerParams, formParams, fileParams, request);

            HttpResponseMessage response = null;
            try
            {
                response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, ct).ConfigureAwait(false);
    
                var headers = new Dictionary<string, IEnumerable<string>>();
                foreach (var item in response.Headers)
                    headers[item.Key] = item.Value;
                if (response.Content != null && response.Content.Headers != null)
                {
                    foreach (var item in response.Content.Headers)
                    {
                        headers[item.Key] = item.Value;
                    }
                }
        
                var status = (int)response.StatusCode;
                if (status != 200)
                {
                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync(ct).ConfigureAwait(false);
                    throw new PetShopApiException(status, "The HTTP status code of the response was not expected (" + status + ").", responseData, headers, null);
                }
            }
            finally
            {
                response?.Dispose();
            }
        }
    }


    private void PrepareRequest(
        string path,
        HttpMethod method,
        Dictionary<string, string> queryParams,
        object body,
        Dictionary<string, string> headerParams,
        Dictionary<string, string> formParams,
        Dictionary<string, FileParameter> fileParams,
        HttpRequestMessage request
    )
    {
        request.Method = method;
    
        // prepare request body
        if (body != null)
        {
            string json;
            if (body is string stringBody)
            {
                json = stringBody;
            }
            else
            {
                json = JsonSerializer.Serialize(body, _options);
            }
    
            var content = new StringContent(json);
            content.Headers.ContentType = MediaTypeHeaderValue.Parse(ContentType);
            request.Content = content;
        }
    
        //form-data
        if (formParams != null && formParams.Count > 0)
        {
            request.Content = new FormUrlEncodedContent(formParams);
        }

        // file sending
        if(fileParams != null)
        {
            using (var content = new MultipartFormDataContent("Upload----" + DateTime.Now.ToString(CultureInfo.InvariantCulture)))
            {
                foreach(var kvp in fileParams)
                {
                    content.Add(ToStreamContent(kvp.Value));
                }
                request.Content = content;
            }
        }
    
        // headers
        request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse(Accept));
        if (headerParams != null)
        {
            foreach (var kvp in headerParams)
            {
                request.Headers.Add(kvp.Key, kvp.Value);
            }
        }
    
        // build url
        var urlBuilder = new StringBuilder();
        if (!string.IsNullOrEmpty(_basePath))
        {
            urlBuilder.Append(_basePath);
        }
    
        urlBuilder.Append(path);
    
        urlBuilder.Append('?');
        if (queryParams != null)
        {
            foreach (var kvp in queryParams)
            {
                urlBuilder.Append(
                    Uri.EscapeDataString(kvp.Key)
                ).Append('=')
                .Append(
                    Uri.EscapeDataString(
                        ConvertToString(kvp.Value, CultureInfo.InvariantCulture)
                    )
                ).Append('&');
            }
        
            urlBuilder.Length--;
        }
    
        var url = urlBuilder.ToString();
        request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
    }
                
    public bool ReadResponseAsString {get;set;}

    protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(
        HttpResponseMessage response, 
        IReadOnlyDictionary<string, IEnumerable<string>> headers,
        CancellationToken ct
    )
    {
        if (response == null || response.Content == null)
        {
            return new ObjectResponseResult<T>(default(T), string.Empty);
        }

        if (ReadResponseAsString)
        {
            var responseText = await response.Content.ReadAsStringAsync(ct).ConfigureAwait(false);
            try
            {
                var typedBody = JsonSerializer.Deserialize<T>(responseText, _options);
                return new ObjectResponseResult<T>(typedBody, responseText);
            }
            catch (JsonException exception)
            {
                var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                throw new PetShopApiException((int)response.StatusCode, message, responseText, headers, exception);
            }
        }
        else
        {
            try
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync(ct).ConfigureAwait(false))
                {
                    var deserialized = await JsonSerializer.DeserializeAsync<T>(responseStream, _options, ct);
                    return new ObjectResponseResult<T>(deserialized, string.Empty);
                }
            }
            catch (JsonException exception)
            {
                var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                throw new PetShopApiException((int)response.StatusCode, message, string.Empty, headers, exception);
            }
        }
    }

    /// <summary>
    /// Update parameters based on authentication.
    /// </summary>
    /// <param name="queryParams">Query parameters.</param>
    /// <param name="headerParams">Header parameters.</param>
    /// <param name="authSettings">Authentication settings.</param>
    public void UpdateParamsForAuth(Dictionary<String, String> queryParams, Dictionary<String, String> headerParams, string[] authSettings)
    {
        if (authSettings == null || authSettings.Length == 0)
            return;

        foreach (string auth in authSettings)
        {
            // determine which one to use
            switch(auth)
            {
                case "api_key":
                    headerParams["api_key"] = GetApiKeyWithPrefix("api_key");
                    
                    break;
                case "petstore_auth":
                    
                    //TODO support oauth
                    break;
                default:
                    //TODO show warning about security definition not found
                    break;
            }
        }
    }

    /// <summary>
    /// Encode string in base64 format.
    /// </summary>
    /// <param name="text">String to be encoded.</param>
    /// <returns>Encoded string.</returns>
    public static string Base64Encode(string text)
    {
        var textByte = Encoding.UTF8.GetBytes(text);
        return Convert.ToBase64String(textByte);
    }

    /// <summary>
    /// Get the API key with prefix.
    /// </summary>
    /// <param name="apiKeyIdentifier">API key identifier (authentication scheme).</param>
    /// <returns>API key with prefix.</returns>
    public string GetApiKeyWithPrefix (string apiKeyIdentifier)
    {
        var apiKeyValue = "";
        Configuration.ApiKey.TryGetValue (apiKeyIdentifier, out apiKeyValue);
        var apiKeyPrefix = "";
        if (Configuration.ApiKeyPrefix.TryGetValue (apiKeyIdentifier, out apiKeyPrefix))
            return apiKeyPrefix + " " + apiKeyValue;
        else
            return apiKeyValue;
    }

    private string ConvertToString(object value, IFormatProvider cultureInfo)
    {
        if (value == null)
        {
            return String.Empty;
        }
    
        if (value is Enum)
        {
            var name = Enum.GetName(value.GetType(), value);
            if (name != null)
            {
                var field = value.GetType().GetTypeInfo().GetDeclaredField(name);
                if (field != null)
                {
                    var attribute = field.GetCustomAttribute(typeof(System.Runtime.Serialization.EnumMemberAttribute)) as System.Runtime.Serialization.EnumMemberAttribute;
                    if (attribute != null)
                    {
                        return attribute.Value ?? name;
                    }
                }
    
                var converted = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                return converted ?? string.Empty;
            }
        }
        else if (value is bool asBool)
        {
            return Convert.ToString(asBool, cultureInfo).ToLowerInvariant();
        }
        else if (value is byte[] asByte)
        {
            return Convert.ToBase64String(asByte);
        }
        else if (value is string[] stringArray)
        {
            return string.Join(",", stringArray);
        }
        else if (value.GetType().IsArray)
        {
            var valueArray = (Array)value;
            var valueTextArray = new string[valueArray.Length];
            for (var i = 0; i < valueArray.Length; i++)
            {
                valueTextArray[i] = ConvertToString(valueArray.GetValue(i), cultureInfo);
            }
            return string.Join(",", valueTextArray);
        }
    
        var result = Convert.ToString(value, cultureInfo);
        return result ?? String.Empty;
    }

    /// <summary>
    /// If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
    /// If parameter is a list of string, join the list with ",".
    /// Otherwise just return the string.
    /// </summary>
    /// <param name="obj">The parameter (header, path, query, form).</param>
    /// <returns>Formatted string.</returns>
    public string ParameterToString(object obj)
    {
        if (obj is DateTime datetime)
            // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
            // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
            // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
            // For example: 2009-06-15T13:45:30.0000000
            return datetime.ToString(Configuration.DateTimeFormat);
        if (obj is List<string> list)
            return String.Join(",", list.ToArray());
        return Convert.ToString(obj);
    }

    /// <summary>
    /// Create FileParameter based on Stream.
    /// </summary>
    /// <param name="name">Parameter name.</param>
    /// <param name="stream">Input stream.</param>
    /// <returns>FileParameter.</returns>
    public FileParameter ParameterToFile(string name, Stream stream)
    {
        if (stream is FileStream fs) 
        {
            return new FileParameter(name, stream, Path.GetFileName(fs.Name));
        }
        return new FileParameter(name, stream, "no_file_name_provided");
    }

    private StreamContent ToStreamContent(FileParameter fileParameter) 
    {
        var stream = fileParameter.FileData;
        var streamContent = new StreamContent(stream);
    
        streamContent.Headers.ContentType = MediaTypeHeaderValue.Parse(fileParameter.ContentType);
    
        var dispositionHeader = ContentDispositionHeaderValue.Parse($"form-data; name=\"{fileParameter.ParameterName}\"; filename=\"{fileParameter.FileName}\"");
        streamContent.Headers.ContentDisposition = dispositionHeader;
    
        return streamContent;
    }

    protected struct ObjectResponseResult<T>
    {
        public ObjectResponseResult(T responseObject, string responseText)
        {
            Object = responseObject;
            Text = responseText;
        }

        public T Object { get; }

        public string Text { get; }
    }

}

public class FileParameter
{
	public FileParameter(string parameterName, Stream fileData, string fileName, string contentType = null) 
	{
		ParameterName = parameterName;
		FileName = fileName;
		FileData = fileData;
		ContentType = contentType;
	}

	public FileParameter(string parameterName, byte[] fileData, string fileName, string contentType = null) : this(parameterName, new MemoryStream(fileData), fileName, contentType)
	{
	}
													
	public Stream FileData { get; }
	public string FileName { get; }
	public string ParameterName { get; }
	public string ContentType { get; }
}