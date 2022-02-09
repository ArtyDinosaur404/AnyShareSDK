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
    /// ConfigGetResCache
    /// </summary>
    [DataContract]
    public partial class ConfigGetResCache :  IEquatable<ConfigGetResCache>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigGetResCache" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConfigGetResCache() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigGetResCache" /> class.
        /// </summary>
        /// <param name="interval">缓存清除时间间隔 (required).</param>
        /// <param name="size">缓存清除空间上限 (required).</param>
        public ConfigGetResCache(long? interval = default(long?), long? size = default(long?))
        {
            this.Interval = interval;
            this.Size = size;
        }
        
        /// <summary>
        /// 缓存清除时间间隔
        /// </summary>
        /// <value>缓存清除时间间隔</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public long? Interval { get; set; }

        /// <summary>
        /// 缓存清除空间上限
        /// </summary>
        /// <value>缓存清除空间上限</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigGetResCache {\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
            return this.Equals(input as ConfigGetResCache);
        }

        /// <summary>
        /// Returns true if ConfigGetResCache instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigGetResCache to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigGetResCache input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
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
                if (this.Interval != null)
                    hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
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
