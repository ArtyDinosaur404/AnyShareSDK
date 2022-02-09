/* 
 * 6.0-OpenDoc_API-文档访问
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
    /// 表示开启了第三方认证，如果未开启，则不会有
    /// </summary>
    [DataContract]
    public partial class Auth1GetconfigResThirdauth :  IEquatable<Auth1GetconfigResThirdauth>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth1GetconfigResThirdauth" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Auth1GetconfigResThirdauth() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth1GetconfigResThirdauth" /> class.
        /// </summary>
        /// <param name="id">唯一第三方认证系统 (required).</param>
        /// <param name="config">第三方认证系统的配置参数 (required).</param>
        public Auth1GetconfigResThirdauth(string id = default(string), Dictionary<string, Object> config = default(Dictionary<string, Object>))
        {
            this.Id = id;
            this.Config = config;
        }
        
        /// <summary>
        /// 唯一第三方认证系统
        /// </summary>
        /// <value>唯一第三方认证系统</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// 第三方认证系统的配置参数
        /// </summary>
        /// <value>第三方认证系统的配置参数</value>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public Dictionary<string, Object> Config { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Auth1GetconfigResThirdauth {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as Auth1GetconfigResThirdauth);
        }

        /// <summary>
        /// Returns true if Auth1GetconfigResThirdauth instances are equal
        /// </summary>
        /// <param name="input">Instance of Auth1GetconfigResThirdauth to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Auth1GetconfigResThirdauth input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Config == input.Config ||
                    this.Config != null &&
                    input.Config != null &&
                    this.Config.SequenceEqual(input.Config)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Config != null)
                    hashCode = hashCode * 59 + this.Config.GetHashCode();
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
            yield break;
        }
    }

}
