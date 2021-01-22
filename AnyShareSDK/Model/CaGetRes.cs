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
    /// CaGetRes
    /// </summary>
    [DataContract]
    public partial class CaGetRes :  IEquatable<CaGetRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaGetRes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CaGetRes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CaGetRes" /> class.
        /// </summary>
        /// <param name="enable">是否开启了CA认证 true表示开启 false表示关闭 (required).</param>
        /// <param name="cainfo">cainfo.</param>
        public CaGetRes(bool? enable = default(bool?), CaGetResCainfo cainfo = default(CaGetResCainfo))
        {
            this.Enable = enable;
            this.Cainfo = cainfo;
        }
        
        /// <summary>
        /// 是否开启了CA认证 true表示开启 false表示关闭
        /// </summary>
        /// <value>是否开启了CA认证 true表示开启 false表示关闭</value>
        [DataMember(Name="enable", EmitDefaultValue=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// Gets or Sets Cainfo
        /// </summary>
        [DataMember(Name="cainfo", EmitDefaultValue=false)]
        public CaGetResCainfo Cainfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaGetRes {\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  Cainfo: ").Append(Cainfo).Append("\n");
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
            return this.Equals(input as CaGetRes);
        }

        /// <summary>
        /// Returns true if CaGetRes instances are equal
        /// </summary>
        /// <param name="input">Instance of CaGetRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaGetRes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enable == input.Enable ||
                    (this.Enable != null &&
                    this.Enable.Equals(input.Enable))
                ) && 
                (
                    this.Cainfo == input.Cainfo ||
                    (this.Cainfo != null &&
                    this.Cainfo.Equals(input.Cainfo))
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
                if (this.Enable != null)
                    hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.Cainfo != null)
                    hashCode = hashCode * 59 + this.Cainfo.GetHashCode();
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
