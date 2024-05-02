using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Text;
using System.Text.Json.Serialization;

namespace PetShop.Models;

/// <summary>
/// Describes the result of uploading an image resource
/// </summary>
[GeneratedCode("swagger-codegen", "1.0")]
public partial class ApiResponse 
{
    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }
    
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
    
    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class ApiResponse {\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
