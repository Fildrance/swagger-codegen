using System;
using System.Collections;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Swagger.Models;

/// <summary>
/// 
/// </summary>
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial class PetPetIdBody 
{
    /// <summary>
    /// Updated name of the pet
    /// </summary>
    /// <value>Updated name of the pet</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    /// <summary>
    /// Updated status of the pet
    /// </summary>
    /// <value>Updated status of the pet</value>
    [JsonPropertyName("status")]
    public string Status { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class PetPetIdBody {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
