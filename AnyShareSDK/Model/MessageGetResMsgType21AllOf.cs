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
    /// MessageGetResMsgType21AllOf
    /// </summary>
    [DataContract]
    public partial class MessageGetResMsgType21AllOf :  IEquatable<MessageGetResMsgType21AllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageGetResMsgType21AllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageGetResMsgType21AllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageGetResMsgType21AllOf" /> class.
        /// </summary>
        /// <param name="creator">创建者 (required).</param>
        /// <param name="modifier">修改者 (required).</param>
        /// <param name="quarantinetype">被隔离类型：1：非法 2：染毒 3：涉黄 (required).</param>
        /// <param name="processtype">处理类型：0：隔离 1：修复（还原消息无需使用） (required).</param>
        public MessageGetResMsgType21AllOf(string creator = default(string), string modifier = default(string), long? quarantinetype = default(long?), long? processtype = default(long?))
        {
            this.Creator = creator;
            this.Modifier = modifier;
            this.Quarantinetype = quarantinetype;
            this.Processtype = processtype;
        }
        
        /// <summary>
        /// 创建者
        /// </summary>
        /// <value>创建者</value>
        [DataMember(Name="creator", EmitDefaultValue=false)]
        public string Creator { get; set; }

        /// <summary>
        /// 修改者
        /// </summary>
        /// <value>修改者</value>
        [DataMember(Name="modifier", EmitDefaultValue=false)]
        public string Modifier { get; set; }

        /// <summary>
        /// 被隔离类型：1：非法 2：染毒 3：涉黄
        /// </summary>
        /// <value>被隔离类型：1：非法 2：染毒 3：涉黄</value>
        [DataMember(Name="quarantinetype", EmitDefaultValue=false)]
        public long? Quarantinetype { get; set; }

        /// <summary>
        /// 处理类型：0：隔离 1：修复（还原消息无需使用）
        /// </summary>
        /// <value>处理类型：0：隔离 1：修复（还原消息无需使用）</value>
        [DataMember(Name="processtype", EmitDefaultValue=false)]
        public long? Processtype { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageGetResMsgType21AllOf {\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  Modifier: ").Append(Modifier).Append("\n");
            sb.Append("  Quarantinetype: ").Append(Quarantinetype).Append("\n");
            sb.Append("  Processtype: ").Append(Processtype).Append("\n");
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
            return this.Equals(input as MessageGetResMsgType21AllOf);
        }

        /// <summary>
        /// Returns true if MessageGetResMsgType21AllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageGetResMsgType21AllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageGetResMsgType21AllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Creator == input.Creator ||
                    (this.Creator != null &&
                    this.Creator.Equals(input.Creator))
                ) && 
                (
                    this.Modifier == input.Modifier ||
                    (this.Modifier != null &&
                    this.Modifier.Equals(input.Modifier))
                ) && 
                (
                    this.Quarantinetype == input.Quarantinetype ||
                    (this.Quarantinetype != null &&
                    this.Quarantinetype.Equals(input.Quarantinetype))
                ) && 
                (
                    this.Processtype == input.Processtype ||
                    (this.Processtype != null &&
                    this.Processtype.Equals(input.Processtype))
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
                if (this.Creator != null)
                    hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.Modifier != null)
                    hashCode = hashCode * 59 + this.Modifier.GetHashCode();
                if (this.Quarantinetype != null)
                    hashCode = hashCode * 59 + this.Quarantinetype.GetHashCode();
                if (this.Processtype != null)
                    hashCode = hashCode * 59 + this.Processtype.GetHashCode();
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