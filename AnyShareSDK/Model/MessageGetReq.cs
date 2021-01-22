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
    /// MessageGetReq
    /// </summary>
    [DataContract]
    public partial class MessageGetReq :  IEquatable<MessageGetReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageGetReq" /> class.
        /// </summary>
        /// <param name="stamp">通知的时间 (unix utc ms)的起始点，可由上一次get提供。第一次get，值为0表示所有.</param>
        /// <param name="sort">返回结果的排序方式。asc：按照消息生成时间升序排列；desc：按照消息生成时间降序排列；默认按照升序排列，即新消息在后面。.</param>
        public MessageGetReq(long? stamp = default(long?), string sort = default(string))
        {
            this.Stamp = stamp;
            this.Sort = sort;
        }
        
        /// <summary>
        /// 通知的时间 (unix utc ms)的起始点，可由上一次get提供。第一次get，值为0表示所有
        /// </summary>
        /// <value>通知的时间 (unix utc ms)的起始点，可由上一次get提供。第一次get，值为0表示所有</value>
        [DataMember(Name="stamp", EmitDefaultValue=false)]
        public long? Stamp { get; set; }

        /// <summary>
        /// 返回结果的排序方式。asc：按照消息生成时间升序排列；desc：按照消息生成时间降序排列；默认按照升序排列，即新消息在后面。
        /// </summary>
        /// <value>返回结果的排序方式。asc：按照消息生成时间升序排列；desc：按照消息生成时间降序排列；默认按照升序排列，即新消息在后面。</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public string Sort { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageGetReq {\n");
            sb.Append("  Stamp: ").Append(Stamp).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
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
            return this.Equals(input as MessageGetReq);
        }

        /// <summary>
        /// Returns true if MessageGetReq instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageGetReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageGetReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Stamp == input.Stamp ||
                    (this.Stamp != null &&
                    this.Stamp.Equals(input.Stamp))
                ) && 
                (
                    this.Sort == input.Sort ||
                    (this.Sort != null &&
                    this.Sort.Equals(input.Sort))
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
                if (this.Stamp != null)
                    hashCode = hashCode * 59 + this.Stamp.GetHashCode();
                if (this.Sort != null)
                    hashCode = hashCode * 59 + this.Sort.GetHashCode();
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
