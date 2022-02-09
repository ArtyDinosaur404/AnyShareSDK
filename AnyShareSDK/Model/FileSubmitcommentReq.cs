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
    /// FileSubmitcommentReq
    /// </summary>
    [DataContract]
    public partial class FileSubmitcommentReq :  IEquatable<FileSubmitcommentReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileSubmitcommentReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileSubmitcommentReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileSubmitcommentReq" /> class.
        /// </summary>
        /// <param name="docid">文件gns路径（列举协议返回） (required).</param>
        /// <param name="answertoid">被回复者id .</param>
        /// <param name="score">评分    评论模式mode 为 2 或 3 时（包含评分功能），需要此项    默认为 -1，表示无评分  .</param>
        /// <param name="comment">评论内容    评论模式mode 为 1 或 3 时（包含评论功能），需要此项    默认为空  .</param>
        public FileSubmitcommentReq(string docid = default(string), string answertoid = default(string), long? score = default(long?), string comment = default(string))
        {
            this.Docid = docid;
            this.Answertoid = answertoid;
            this.Score = score;
            this.Comment = comment;
        }
        
        /// <summary>
        /// 文件gns路径（列举协议返回）
        /// </summary>
        /// <value>文件gns路径（列举协议返回）</value>
        [DataMember(Name="docid", EmitDefaultValue=false)]
        public string Docid { get; set; }

        /// <summary>
        /// 被回复者id 
        /// </summary>
        /// <value>被回复者id </value>
        [DataMember(Name="answertoid", EmitDefaultValue=false)]
        public string Answertoid { get; set; }

        /// <summary>
        /// 评分    评论模式mode 为 2 或 3 时（包含评分功能），需要此项    默认为 -1，表示无评分  
        /// </summary>
        /// <value>评分    评论模式mode 为 2 或 3 时（包含评分功能），需要此项    默认为 -1，表示无评分  </value>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public long? Score { get; set; }

        /// <summary>
        /// 评论内容    评论模式mode 为 1 或 3 时（包含评论功能），需要此项    默认为空  
        /// </summary>
        /// <value>评论内容    评论模式mode 为 1 或 3 时（包含评论功能），需要此项    默认为空  </value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileSubmitcommentReq {\n");
            sb.Append("  Docid: ").Append(Docid).Append("\n");
            sb.Append("  Answertoid: ").Append(Answertoid).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
            return this.Equals(input as FileSubmitcommentReq);
        }

        /// <summary>
        /// Returns true if FileSubmitcommentReq instances are equal
        /// </summary>
        /// <param name="input">Instance of FileSubmitcommentReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileSubmitcommentReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Docid == input.Docid ||
                    (this.Docid != null &&
                    this.Docid.Equals(input.Docid))
                ) && 
                (
                    this.Answertoid == input.Answertoid ||
                    (this.Answertoid != null &&
                    this.Answertoid.Equals(input.Answertoid))
                ) && 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
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
                if (this.Docid != null)
                    hashCode = hashCode * 59 + this.Docid.GetHashCode();
                if (this.Answertoid != null)
                    hashCode = hashCode * 59 + this.Answertoid.GetHashCode();
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
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
