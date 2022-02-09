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
    /// Perm1GetinternallinktemplateRes
    /// </summary>
    [DataContract]
    public partial class Perm1GetinternallinktemplateRes :  IEquatable<Perm1GetinternallinktemplateRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Perm1GetinternallinktemplateRes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Perm1GetinternallinktemplateRes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Perm1GetinternallinktemplateRes" /> class.
        /// </summary>
        /// <param name="allowperm">允许设置的权限 (required).</param>
        /// <param name="defaultperm">默认设置的权限 (required).</param>
        /// <param name="allowowner">允许设定所有者 (required).</param>
        /// <param name="defaultowner">默认允许设置所有者 (required).</param>
        /// <param name="limitexpiredays">是否限制有效期 (required).</param>
        /// <param name="allowexpiredays">limitexpiredays&#x3D;true  表示最大有效期  limitexpiredays&#x3D;false  表示默认有效期 (required).</param>
        public Perm1GetinternallinktemplateRes(long? allowperm = default(long?), long? defaultperm = default(long?), bool? allowowner = default(bool?), bool? defaultowner = default(bool?), bool? limitexpiredays = default(bool?), long? allowexpiredays = default(long?))
        {
            this.Allowperm = allowperm;
            this.Defaultperm = defaultperm;
            this.Allowowner = allowowner;
            this.Defaultowner = defaultowner;
            this.Limitexpiredays = limitexpiredays;
            this.Allowexpiredays = allowexpiredays;
        }
        
        /// <summary>
        /// 允许设置的权限
        /// </summary>
        /// <value>允许设置的权限</value>
        [DataMember(Name="allowperm", EmitDefaultValue=false)]
        public long? Allowperm { get; set; }

        /// <summary>
        /// 默认设置的权限
        /// </summary>
        /// <value>默认设置的权限</value>
        [DataMember(Name="defaultperm", EmitDefaultValue=false)]
        public long? Defaultperm { get; set; }

        /// <summary>
        /// 允许设定所有者
        /// </summary>
        /// <value>允许设定所有者</value>
        [DataMember(Name="allowowner", EmitDefaultValue=false)]
        public bool? Allowowner { get; set; }

        /// <summary>
        /// 默认允许设置所有者
        /// </summary>
        /// <value>默认允许设置所有者</value>
        [DataMember(Name="defaultowner", EmitDefaultValue=false)]
        public bool? Defaultowner { get; set; }

        /// <summary>
        /// 是否限制有效期
        /// </summary>
        /// <value>是否限制有效期</value>
        [DataMember(Name="limitexpiredays", EmitDefaultValue=false)]
        public bool? Limitexpiredays { get; set; }

        /// <summary>
        /// limitexpiredays&#x3D;true  表示最大有效期  limitexpiredays&#x3D;false  表示默认有效期
        /// </summary>
        /// <value>limitexpiredays&#x3D;true  表示最大有效期  limitexpiredays&#x3D;false  表示默认有效期</value>
        [DataMember(Name="allowexpiredays", EmitDefaultValue=false)]
        public long? Allowexpiredays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Perm1GetinternallinktemplateRes {\n");
            sb.Append("  Allowperm: ").Append(Allowperm).Append("\n");
            sb.Append("  Defaultperm: ").Append(Defaultperm).Append("\n");
            sb.Append("  Allowowner: ").Append(Allowowner).Append("\n");
            sb.Append("  Defaultowner: ").Append(Defaultowner).Append("\n");
            sb.Append("  Limitexpiredays: ").Append(Limitexpiredays).Append("\n");
            sb.Append("  Allowexpiredays: ").Append(Allowexpiredays).Append("\n");
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
            return this.Equals(input as Perm1GetinternallinktemplateRes);
        }

        /// <summary>
        /// Returns true if Perm1GetinternallinktemplateRes instances are equal
        /// </summary>
        /// <param name="input">Instance of Perm1GetinternallinktemplateRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Perm1GetinternallinktemplateRes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Allowperm == input.Allowperm ||
                    (this.Allowperm != null &&
                    this.Allowperm.Equals(input.Allowperm))
                ) && 
                (
                    this.Defaultperm == input.Defaultperm ||
                    (this.Defaultperm != null &&
                    this.Defaultperm.Equals(input.Defaultperm))
                ) && 
                (
                    this.Allowowner == input.Allowowner ||
                    (this.Allowowner != null &&
                    this.Allowowner.Equals(input.Allowowner))
                ) && 
                (
                    this.Defaultowner == input.Defaultowner ||
                    (this.Defaultowner != null &&
                    this.Defaultowner.Equals(input.Defaultowner))
                ) && 
                (
                    this.Limitexpiredays == input.Limitexpiredays ||
                    (this.Limitexpiredays != null &&
                    this.Limitexpiredays.Equals(input.Limitexpiredays))
                ) && 
                (
                    this.Allowexpiredays == input.Allowexpiredays ||
                    (this.Allowexpiredays != null &&
                    this.Allowexpiredays.Equals(input.Allowexpiredays))
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
                if (this.Allowperm != null)
                    hashCode = hashCode * 59 + this.Allowperm.GetHashCode();
                if (this.Defaultperm != null)
                    hashCode = hashCode * 59 + this.Defaultperm.GetHashCode();
                if (this.Allowowner != null)
                    hashCode = hashCode * 59 + this.Allowowner.GetHashCode();
                if (this.Defaultowner != null)
                    hashCode = hashCode * 59 + this.Defaultowner.GetHashCode();
                if (this.Limitexpiredays != null)
                    hashCode = hashCode * 59 + this.Limitexpiredays.GetHashCode();
                if (this.Allowexpiredays != null)
                    hashCode = hashCode * 59 + this.Allowexpiredays.GetHashCode();
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
