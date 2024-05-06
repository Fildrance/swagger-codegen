using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Text;
using System.Text.Json.Serialization;

namespace PetShop.Models;

/// <summary>
/// An order for a pets from the pet store
/// </summary>
[GeneratedCode("swagger-codegen", "1.0")]
public partial class Order 
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }
    
    /// <summary>
    /// Gets or Sets PetId
    /// </summary>
    [JsonPropertyName("petId")]
    public long? PetId { get; set; }
    
    /// <summary>
    /// Gets or Sets Quantity
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? Quantity { get; set; }
    
    /// <summary>
    /// Gets or Sets ShipDate
    /// </summary>
    [JsonPropertyName("shipDate")]
    public DateTime? ShipDate { get; set; }
    
    /// <summary>
    /// Order Status
    /// </summary>
    /// <value>Order Status</value>
    [JsonPropertyName("status")]
    public string Status { get; set; }
    
    /// <summary>
    /// Gets or Sets Complete
    /// </summary>
    [JsonPropertyName("complete")]
    public bool? Complete { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class Order {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  PetId: ").Append(PetId).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Complete: ").Append(Complete).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
