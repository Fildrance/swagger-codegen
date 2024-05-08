using System;
using System.Collections;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Text;
using System.Text.Json.Serialization;

namespace PetShop.Models;

/// <summary>
/// 
/// </summary>
[GeneratedCode("swagger-codegen", "unset")]
public partial class PetIdUploadImageBody 
{
    /// <summary>
    /// Additional data to pass to server
    /// </summary>
    /// <value>Additional data to pass to server</value>
    [JsonPropertyName("additionalMetadata")]
    public string AdditionalMetadata { get; set; }
    
    /// <summary>
    /// file to upload
    /// </summary>
    /// <value>file to upload</value>
    [JsonPropertyName("file")]
    public byte[] File { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class PetIdUploadImageBody {\n");
      sb.Append("  AdditionalMetadata: ").Append(AdditionalMetadata).Append("\n");
      sb.Append("  File: ").Append(File).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
