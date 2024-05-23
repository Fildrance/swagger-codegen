using System;
using System.Collections;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Swagger.Models
{
    /// <summary>
    /// Describes the result of uploading an image resource
    /// </summary>
    [GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
    public partial class ModelApiResponse 
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
          sb.Append("class ModelApiResponse {\n");
          sb.Append("  Code: ").Append(Code).Append("\n");
          sb.Append("  Type: ").Append(Type).Append("\n");
          sb.Append("  Message: ").Append(Message).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
        
    }
}