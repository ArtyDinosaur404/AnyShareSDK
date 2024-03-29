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
    /// 本地同步策略
    /// </summary>
    [DataContract]
    public partial class ConfigGetResLocalsync :  IEquatable<ConfigGetResLocalsync>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigGetResLocalsync" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConfigGetResLocalsync() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigGetResLocalsync" /> class.
        /// </summary>
        /// <param name="openstatus">是否开启本地同步配置 (required).</param>
        /// <param name="deletestatus">是否允许删除配置的同步任务 (required).</param>
        public ConfigGetResLocalsync(bool? openstatus = default(bool?), bool? deletestatus = default(bool?))
        {
            this.Openstatus = openstatus;
            this.Deletestatus = deletestatus;
        }
        
        /// <summary>
        /// 是否开启本地同步配置
        /// </summary>
        /// <value>是否开启本地同步配置</value>
        [DataMember(Name="openstatus", EmitDefaultValue=false)]
        public bool? Openstatus { get; set; }

        /// <summary>
        /// 是否允许删除配置的同步任务
        /// </summary>
        /// <value>是否允许删除配置的同步任务</value>
        [DataMember(Name="deletestatus", EmitDefaultValue=false)]
        public bool? Deletestatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigGetResLocalsync {\n");
            sb.Append("  Openstatus: ").Append(Openstatus).Append("\n");
            sb.Append("  Deletestatus: ").Append(Deletestatus).Append("\n");
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
            return this.Equals(input as ConfigGetResLocalsync);
        }

        /// <summary>
        /// Returns true if ConfigGetResLocalsync instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigGetResLocalsync to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigGetResLocalsync input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Openstatus == input.Openstatus ||
                    (this.Openstatus != null &&
                    this.Openstatus.Equals(input.Openstatus))
                ) && 
                (
                    this.Deletestatus == input.Deletestatus ||
                    (this.Deletestatus != null &&
                    this.Deletestatus.Equals(input.Deletestatus))
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
                if (this.Openstatus != null)
                    hashCode = hashCode * 59 + this.Openstatus.GetHashCode();
                if (this.Deletestatus != null)
                    hashCode = hashCode * 59 + this.Deletestatus.GetHashCode();
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
