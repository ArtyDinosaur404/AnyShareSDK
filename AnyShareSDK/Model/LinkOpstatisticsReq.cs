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
    /// LinkOpstatisticsReq
    /// </summary>
    [DataContract]
    public partial class LinkOpstatisticsReq :  IEquatable<LinkOpstatisticsReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkOpstatisticsReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LinkOpstatisticsReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkOpstatisticsReq" /> class.
        /// </summary>
        /// <param name="linkDocid">外链文件gns路径（getlinked协议返回） (required).</param>
        /// <param name="fileDocid">文件gns（opfiles协议返回） (required).</param>
        /// <param name="start">开始位置，默认为0.</param>
        /// <param name="limit">分页条数，默认为-1，返回start后面的所有记录.</param>
        public LinkOpstatisticsReq(string linkDocid = default(string), string fileDocid = default(string), long? start = default(long?), long? limit = default(long?))
        {
            this.LinkDocid = linkDocid;
            this.FileDocid = fileDocid;
            this.Start = start;
            this.Limit = limit;
        }
        
        /// <summary>
        /// 外链文件gns路径（getlinked协议返回）
        /// </summary>
        /// <value>外链文件gns路径（getlinked协议返回）</value>
        [DataMember(Name="link_docid", EmitDefaultValue=false)]
        public string LinkDocid { get; set; }

        /// <summary>
        /// 文件gns（opfiles协议返回）
        /// </summary>
        /// <value>文件gns（opfiles协议返回）</value>
        [DataMember(Name="file_docid", EmitDefaultValue=false)]
        public string FileDocid { get; set; }

        /// <summary>
        /// 开始位置，默认为0
        /// </summary>
        /// <value>开始位置，默认为0</value>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public long? Start { get; set; }

        /// <summary>
        /// 分页条数，默认为-1，返回start后面的所有记录
        /// </summary>
        /// <value>分页条数，默认为-1，返回start后面的所有记录</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinkOpstatisticsReq {\n");
            sb.Append("  LinkDocid: ").Append(LinkDocid).Append("\n");
            sb.Append("  FileDocid: ").Append(FileDocid).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
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
            return this.Equals(input as LinkOpstatisticsReq);
        }

        /// <summary>
        /// Returns true if LinkOpstatisticsReq instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkOpstatisticsReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkOpstatisticsReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LinkDocid == input.LinkDocid ||
                    (this.LinkDocid != null &&
                    this.LinkDocid.Equals(input.LinkDocid))
                ) && 
                (
                    this.FileDocid == input.FileDocid ||
                    (this.FileDocid != null &&
                    this.FileDocid.Equals(input.FileDocid))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
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
                if (this.LinkDocid != null)
                    hashCode = hashCode * 59 + this.LinkDocid.GetHashCode();
                if (this.FileDocid != null)
                    hashCode = hashCode * 59 + this.FileDocid.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
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