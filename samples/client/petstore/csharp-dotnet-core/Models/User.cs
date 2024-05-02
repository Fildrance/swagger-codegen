using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Text;
using System.Text.Json.Serialization;

namespace PetShop.Models;

/// <summary>
/// A User who is purchasing from the pet store
/// </summary>
[GeneratedCode("swagger-codegen", "1.0")]
public partial class User 
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }
    
    /// <summary>
    /// Gets or Sets Username
    /// </summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }
    
    /// <summary>
    /// Gets or Sets FirstName
    /// </summary>
    [JsonPropertyName("firstName")]
    public string FirstName { get; set; }
    
    /// <summary>
    /// Gets or Sets LastName
    /// </summary>
    [JsonPropertyName("lastName")]
    public string LastName { get; set; }
    
    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [JsonPropertyName("email")]
    public string Email { get; set; }
    
    /// <summary>
    /// Gets or Sets Password
    /// </summary>
    [JsonPropertyName("password")]
    public string Password { get; set; }
    
    /// <summary>
    /// Gets or Sets Phone
    /// </summary>
    [JsonPropertyName("phone")]
    public string Phone { get; set; }
    
    /// <summary>
    /// User Status
    /// </summary>
    /// <value>User Status</value>
    [JsonPropertyName("userStatus")]
    public int? UserStatus { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class User {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("  UserStatus: ").Append(UserStatus).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
