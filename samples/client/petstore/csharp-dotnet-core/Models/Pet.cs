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
public partial class Pet 
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }
    
    /// <summary>
    /// Gets or Sets Category
    /// </summary>
    [JsonPropertyName("category")]
    public Category Category { get; set; }
    
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    /// <summary>
    /// Gets or Sets PhotoUrls
    /// </summary>
    [JsonPropertyName("photoUrls")]
    public List<string> PhotoUrls { get; set; }
    
    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [JsonPropertyName("tags")]
    public List<Tag> Tags { get; set; }
    
    /// <summary>
    /// pet status in the store
    /// </summary>
    /// <value>pet status in the store</value>
    [JsonPropertyName("status")]
    public string Status { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class Pet {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PhotoUrls: ").Append(PhotoUrls).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
