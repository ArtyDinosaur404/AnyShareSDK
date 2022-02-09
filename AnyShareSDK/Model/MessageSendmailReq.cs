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
    /// MessageSendmailReq
    /// </summary>
    [DataContract]
    public partial class MessageSendmailReq :  IEquatable<MessageSendmailReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSendmailReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageSendmailReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSendmailReq" /> class.
        /// </summary>
        /// <param name="mailto">收件人邮箱地址列表 (required).</param>
        /// <param name="subject">邮件主题.</param>
        /// <param name="content">邮件内容（由html格式组织）.</param>
        public MessageSendmailReq(List<string> mailto = default(List<string>), string subject = default(string), string content = default(string))
        {
            this.Mailto = mailto;
            this.Subject = subject;
            this.Content = content;
        }
        
        /// <summary>
        /// 收件人邮箱地址列表
        /// </summary>
        /// <value>收件人邮箱地址列表</value>
        [DataMember(Name="mailto", EmitDefaultValue=false)]
        public List<string> Mailto { get; set; }

        /// <summary>
        /// 邮件主题
        /// </summary>
        /// <value>邮件主题</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// 邮件内容（由html格式组织）
        /// </summary>
        /// <value>邮件内容（由html格式组织）</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageSendmailReq {\n");
            sb.Append("  Mailto: ").Append(Mailto).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
            return this.Equals(input as MessageSendmailReq);
        }

        /// <summary>
        /// Returns true if MessageSendmailReq instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageSendmailReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageSendmailReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Mailto == input.Mailto ||
                    this.Mailto != null &&
                    input.Mailto != null &&
                    this.Mailto.SequenceEqual(input.Mailto)
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
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
                if (this.Mailto != null)
                    hashCode = hashCode * 59 + this.Mailto.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
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
