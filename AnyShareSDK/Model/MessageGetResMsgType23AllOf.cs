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
    /// MessageGetResMsgType23AllOf
    /// </summary>
    [DataContract]
    public partial class MessageGetResMsgType23AllOf :  IEquatable<MessageGetResMsgType23AllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageGetResMsgType23AllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageGetResMsgType23AllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageGetResMsgType23AllOf" /> class.
        /// </summary>
        /// <param name="antivirusadmin">防病毒管理员 (required).</param>
        /// <param name="antivirusop">杀毒类型   1 表示隔离  2表示修复 (required).</param>
        public MessageGetResMsgType23AllOf(string antivirusadmin = default(string), long? antivirusop = default(long?))
        {
            this.Antivirusadmin = antivirusadmin;
            this.Antivirusop = antivirusop;
        }
        
        /// <summary>
        /// 防病毒管理员
        /// </summary>
        /// <value>防病毒管理员</value>
        [DataMember(Name="antivirusadmin", EmitDefaultValue=false)]
        public string Antivirusadmin { get; set; }

        /// <summary>
        /// 杀毒类型   1 表示隔离  2表示修复
        /// </summary>
        /// <value>杀毒类型   1 表示隔离  2表示修复</value>
        [DataMember(Name="antivirusop", EmitDefaultValue=false)]
        public long? Antivirusop { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageGetResMsgType23AllOf {\n");
            sb.Append("  Antivirusadmin: ").Append(Antivirusadmin).Append("\n");
            sb.Append("  Antivirusop: ").Append(Antivirusop).Append("\n");
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
            return this.Equals(input as MessageGetResMsgType23AllOf);
        }

        /// <summary>
        /// Returns true if MessageGetResMsgType23AllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageGetResMsgType23AllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageGetResMsgType23AllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Antivirusadmin == input.Antivirusadmin ||
                    (this.Antivirusadmin != null &&
                    this.Antivirusadmin.Equals(input.Antivirusadmin))
                ) && 
                (
                    this.Antivirusop == input.Antivirusop ||
                    (this.Antivirusop != null &&
                    this.Antivirusop.Equals(input.Antivirusop))
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
                if (this.Antivirusadmin != null)
                    hashCode = hashCode * 59 + this.Antivirusadmin.GetHashCode();
                if (this.Antivirusop != null)
                    hashCode = hashCode * 59 + this.Antivirusop.GetHashCode();
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
