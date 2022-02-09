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
    /// AuditGetdocapplysRes
    /// </summary>
    [DataContract]
    public partial class AuditGetdocapplysRes :  IEquatable<AuditGetdocapplysRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditGetdocapplysRes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuditGetdocapplysRes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditGetdocapplysRes" /> class.
        /// </summary>
        /// <param name="applyinfos">申请信息 (required).</param>
        public AuditGetdocapplysRes(List<AuditGetdocapplysResApplyinfo> applyinfos = default(List<AuditGetdocapplysResApplyinfo>))
        {
            this.Applyinfos = applyinfos;
        }
        
        /// <summary>
        /// 申请信息
        /// </summary>
        /// <value>申请信息</value>
        [DataMember(Name="applyinfos", EmitDefaultValue=false)]
        public List<AuditGetdocapplysResApplyinfo> Applyinfos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditGetdocapplysRes {\n");
            sb.Append("  Applyinfos: ").Append(Applyinfos).Append("\n");
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
            return this.Equals(input as AuditGetdocapplysRes);
        }

        /// <summary>
        /// Returns true if AuditGetdocapplysRes instances are equal
        /// </summary>
        /// <param name="input">Instance of AuditGetdocapplysRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditGetdocapplysRes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Applyinfos == input.Applyinfos ||
                    this.Applyinfos != null &&
                    input.Applyinfos != null &&
                    this.Applyinfos.SequenceEqual(input.Applyinfos)
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
                if (this.Applyinfos != null)
                    hashCode = hashCode * 59 + this.Applyinfos.GetHashCode();
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
