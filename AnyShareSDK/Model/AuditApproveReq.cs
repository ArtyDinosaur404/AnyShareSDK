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
    /// AuditApproveReq
    /// </summary>
    [DataContract]
    public partial class AuditApproveReq :  IEquatable<AuditApproveReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditApproveReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuditApproveReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditApproveReq" /> class.
        /// </summary>
        /// <param name="applyid">申请记录id (required).</param>
        /// <param name="result">true表示通过 false表示拒绝 null表示拒绝 (required).</param>
        /// <param name="msg">审核说明 (required).</param>
        public AuditApproveReq(string applyid = default(string), bool? result = default(bool?), string msg = default(string))
        {
            this.Applyid = applyid;
            this.Result = result;
            this.Msg = msg;
        }
        
        /// <summary>
        /// 申请记录id
        /// </summary>
        /// <value>申请记录id</value>
        [DataMember(Name="applyid", EmitDefaultValue=false)]
        public string Applyid { get; set; }

        /// <summary>
        /// true表示通过 false表示拒绝 null表示拒绝
        /// </summary>
        /// <value>true表示通过 false表示拒绝 null表示拒绝</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public bool? Result { get; set; }

        /// <summary>
        /// 审核说明
        /// </summary>
        /// <value>审核说明</value>
        [DataMember(Name="msg", EmitDefaultValue=false)]
        public string Msg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditApproveReq {\n");
            sb.Append("  Applyid: ").Append(Applyid).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Msg: ").Append(Msg).Append("\n");
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
            return this.Equals(input as AuditApproveReq);
        }

        /// <summary>
        /// Returns true if AuditApproveReq instances are equal
        /// </summary>
        /// <param name="input">Instance of AuditApproveReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditApproveReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Applyid == input.Applyid ||
                    (this.Applyid != null &&
                    this.Applyid.Equals(input.Applyid))
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.Msg == input.Msg ||
                    (this.Msg != null &&
                    this.Msg.Equals(input.Msg))
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
                if (this.Applyid != null)
                    hashCode = hashCode * 59 + this.Applyid.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Msg != null)
                    hashCode = hashCode * 59 + this.Msg.GetHashCode();
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
