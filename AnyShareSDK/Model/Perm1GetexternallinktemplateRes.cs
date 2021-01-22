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
    /// Perm1GetexternallinktemplateRes
    /// </summary>
    [DataContract]
    public partial class Perm1GetexternallinktemplateRes :  IEquatable<Perm1GetexternallinktemplateRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Perm1GetexternallinktemplateRes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Perm1GetexternallinktemplateRes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Perm1GetexternallinktemplateRes" /> class.
        /// </summary>
        /// <param name="limitexpiredays">是否限制外链有效期 (required).</param>
        /// <param name="allowexpiredays">limitexpireday&#x3D;fasle  表示默认有效期  limitexpireday&#x3D;true  表示最大有效期 (required).</param>
        /// <param name="allowperm">可设定的权限 (required).</param>
        /// <param name="defaultperm">默认权限 (required).</param>
        /// <param name="limitaccesstimes">是否限制打开次数 (required).</param>
        /// <param name="allowaccesstimes">limitaccesstimes&#x3D;false  表示默认打开次数  limitaccesstimes&#x3D;true  表示最大打开次数 (required).</param>
        /// <param name="accesspassword">是否强制使用访问密码 (required).</param>
        public Perm1GetexternallinktemplateRes(bool? limitexpiredays = default(bool?), long? allowexpiredays = default(long?), long? allowperm = default(long?), long? defaultperm = default(long?), bool? limitaccesstimes = default(bool?), long? allowaccesstimes = default(long?), bool? accesspassword = default(bool?))
        {
            this.Limitexpiredays = limitexpiredays;
            this.Allowexpiredays = allowexpiredays;
            this.Allowperm = allowperm;
            this.Defaultperm = defaultperm;
            this.Limitaccesstimes = limitaccesstimes;
            this.Allowaccesstimes = allowaccesstimes;
            this.Accesspassword = accesspassword;
        }
        
        /// <summary>
        /// 是否限制外链有效期
        /// </summary>
        /// <value>是否限制外链有效期</value>
        [DataMember(Name="limitexpiredays", EmitDefaultValue=false)]
        public bool? Limitexpiredays { get; set; }

        /// <summary>
        /// limitexpireday&#x3D;fasle  表示默认有效期  limitexpireday&#x3D;true  表示最大有效期
        /// </summary>
        /// <value>limitexpireday&#x3D;fasle  表示默认有效期  limitexpireday&#x3D;true  表示最大有效期</value>
        [DataMember(Name="allowexpiredays", EmitDefaultValue=false)]
        public long? Allowexpiredays { get; set; }

        /// <summary>
        /// 可设定的权限
        /// </summary>
        /// <value>可设定的权限</value>
        [DataMember(Name="allowperm", EmitDefaultValue=false)]
        public long? Allowperm { get; set; }

        /// <summary>
        /// 默认权限
        /// </summary>
        /// <value>默认权限</value>
        [DataMember(Name="defaultperm", EmitDefaultValue=false)]
        public long? Defaultperm { get; set; }

        /// <summary>
        /// 是否限制打开次数
        /// </summary>
        /// <value>是否限制打开次数</value>
        [DataMember(Name="limitaccesstimes", EmitDefaultValue=false)]
        public bool? Limitaccesstimes { get; set; }

        /// <summary>
        /// limitaccesstimes&#x3D;false  表示默认打开次数  limitaccesstimes&#x3D;true  表示最大打开次数
        /// </summary>
        /// <value>limitaccesstimes&#x3D;false  表示默认打开次数  limitaccesstimes&#x3D;true  表示最大打开次数</value>
        [DataMember(Name="allowaccesstimes", EmitDefaultValue=false)]
        public long? Allowaccesstimes { get; set; }

        /// <summary>
        /// 是否强制使用访问密码
        /// </summary>
        /// <value>是否强制使用访问密码</value>
        [DataMember(Name="accesspassword", EmitDefaultValue=false)]
        public bool? Accesspassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Perm1GetexternallinktemplateRes {\n");
            sb.Append("  Limitexpiredays: ").Append(Limitexpiredays).Append("\n");
            sb.Append("  Allowexpiredays: ").Append(Allowexpiredays).Append("\n");
            sb.Append("  Allowperm: ").Append(Allowperm).Append("\n");
            sb.Append("  Defaultperm: ").Append(Defaultperm).Append("\n");
            sb.Append("  Limitaccesstimes: ").Append(Limitaccesstimes).Append("\n");
            sb.Append("  Allowaccesstimes: ").Append(Allowaccesstimes).Append("\n");
            sb.Append("  Accesspassword: ").Append(Accesspassword).Append("\n");
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
            return this.Equals(input as Perm1GetexternallinktemplateRes);
        }

        /// <summary>
        /// Returns true if Perm1GetexternallinktemplateRes instances are equal
        /// </summary>
        /// <param name="input">Instance of Perm1GetexternallinktemplateRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Perm1GetexternallinktemplateRes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Limitexpiredays == input.Limitexpiredays ||
                    (this.Limitexpiredays != null &&
                    this.Limitexpiredays.Equals(input.Limitexpiredays))
                ) && 
                (
                    this.Allowexpiredays == input.Allowexpiredays ||
                    (this.Allowexpiredays != null &&
                    this.Allowexpiredays.Equals(input.Allowexpiredays))
                ) && 
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
                    this.Limitaccesstimes == input.Limitaccesstimes ||
                    (this.Limitaccesstimes != null &&
                    this.Limitaccesstimes.Equals(input.Limitaccesstimes))
                ) && 
                (
                    this.Allowaccesstimes == input.Allowaccesstimes ||
                    (this.Allowaccesstimes != null &&
                    this.Allowaccesstimes.Equals(input.Allowaccesstimes))
                ) && 
                (
                    this.Accesspassword == input.Accesspassword ||
                    (this.Accesspassword != null &&
                    this.Accesspassword.Equals(input.Accesspassword))
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
                if (this.Limitexpiredays != null)
                    hashCode = hashCode * 59 + this.Limitexpiredays.GetHashCode();
                if (this.Allowexpiredays != null)
                    hashCode = hashCode * 59 + this.Allowexpiredays.GetHashCode();
                if (this.Allowperm != null)
                    hashCode = hashCode * 59 + this.Allowperm.GetHashCode();
                if (this.Defaultperm != null)
                    hashCode = hashCode * 59 + this.Defaultperm.GetHashCode();
                if (this.Limitaccesstimes != null)
                    hashCode = hashCode * 59 + this.Limitaccesstimes.GetHashCode();
                if (this.Allowaccesstimes != null)
                    hashCode = hashCode * 59 + this.Allowaccesstimes.GetHashCode();
                if (this.Accesspassword != null)
                    hashCode = hashCode * 59 + this.Accesspassword.GetHashCode();
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
