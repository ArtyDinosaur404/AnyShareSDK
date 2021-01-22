/* 
 * OpenDoc_API-文档访问
 *
 * API to access AnyShare    如有任何疑问，可到开发者社区提问：https://developers.aishu.cn  # Authentication  - 调用需要鉴权的API，必须将token放在HTTP header中：\"Authorization: Bearer ACCESS_TOKEN\"  - 对于GET请求，除了将token放在HTTP header中，也可以将token放在URL query string中：\"tokenid=ACCESS_TOKEN\"  
 *
 * The version of the OpenAPI document: 6.0.10
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = AnyShareSDK.Client.OpenAPIDateConverter;

namespace AnyShareSDK.Model
{
    /// <summary>
    /// MessageGetResMsgType8
    /// </summary>
    [DataContract]
    public partial class MessageGetResMsgType8 : MessageGetResMsgBase,  IEquatable<MessageGetResMsgType8>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageGetResMsgType8" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageGetResMsgType8() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageGetResMsgType8" /> class.
        /// </summary>
        public MessageGetResMsgType8(string accessorname = default(string), AccessortypeEnum accessortype = default(AccessortypeEnum), long? csf = default(long?), string id = default(string), bool? isdir = default(bool?), bool? isread = default(bool?), string sender = default(string), long? time = default(long?), long? type = default(long?), string url = default(string)) : base()
        {
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageGetResMsgType8 {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MessageGetResMsgType8);
        }

        /// <summary>
        /// Returns true if MessageGetResMsgType8 instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageGetResMsgType8 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageGetResMsgType8 input)
        {
            if (input == null)
                return false;

            return base.Equals(input);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
