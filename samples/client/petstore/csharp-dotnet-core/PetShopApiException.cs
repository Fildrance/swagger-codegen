using System;
using System.Collections.Generic;

namespace PetShop;

/// <summary>
/// API Exception
/// </summary>
public class PetShopApiException : Exception {
    /// <summary>
    /// Gets or sets the error code (HTTP status code)
    /// </summary>
    /// <value>The error code (HTTP status code).</value>
    public int ErrorCode { get; set; }
    
    /// <summary>
    /// Gets or sets the error content (body json object)
    /// </summary>
    /// <value>The error content (Http response body).</value>
    public Object ErrorContent { get; private set; }
    
    public IReadOnlyDictionary<string, IEnumerable<string>> Headers{get; private set;}  
    
    /// <summary>
    /// Initializes a new instance of the <see cref="PetShopApiException"/> class.
    /// </summary>
    public PetShopApiException() {}
    
    /// <summary>
    /// Initializes a new instance of the <see cref="PetShopApiException"/> class.
    /// </summary>
    /// <param name="errorCode">HTTP status code.</param>
    /// <param name="message">Error message.</param>
    public PetShopApiException(int errorCode, string message) : this(errorCode, message, null, null)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the <see cref="PetShopApiException"/> class.
    /// </summary>
    /// <param name="errorCode">HTTP status code.</param>
    /// <param name="message">Error message.</param>
    /// <param name="errorContent">Error content.</param>
    public PetShopApiException(int errorCode, string message, Object errorContent = null, IReadOnlyDictionary<string,  IEnumerable<string>> headers = null, Exception original = null) : base(message, original) 
    {
        ErrorCode = errorCode;
        ErrorContent = errorContent;
        Headers = headers;
    }

}
