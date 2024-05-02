using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Text;
using System.Text.Json.Serialization;

namespace PetShop.Models;

/// <summary>
/// some description 
/// </summary>
[GeneratedCode("swagger-codegen", "1.0")]
public partial class Amount 
{
    /// <summary>
    /// some description 
    /// </summary>
    /// <value>some description </value>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
    
    /// <summary>
    /// Gets or Sets Currency
    /// </summary>
    [JsonPropertyName("currency")]
    public Currency Currency { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class Amount {\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
