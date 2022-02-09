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
    /// FileAddtagsRes
    /// </summary>
    [DataContract]
    public partial class FileAddtagsRes :  IEquatable<FileAddtagsRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileAddtagsRes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileAddtagsRes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileAddtagsRes" /> class.
        /// </summary>
        /// <param name="tagMaxNum">允许文件拥有的标签的最大数量 (required).</param>
        /// <param name="unsettagnum">由于标签数量限制未设置成功的标签数 (required).</param>
        /// <param name="unsettags">未设置成功的标签数组 (required).</param>
        public FileAddtagsRes(long? tagMaxNum = default(long?), long? unsettagnum = default(long?), List<string> unsettags = default(List<string>))
        {
            this.TagMaxNum = tagMaxNum;
            this.Unsettagnum = unsettagnum;
            this.Unsettags = unsettags;
        }
        
        /// <summary>
        /// 允许文件拥有的标签的最大数量
        /// </summary>
        /// <value>允许文件拥有的标签的最大数量</value>
        [DataMember(Name="tag_max_num", EmitDefaultValue=false)]
        public long? TagMaxNum { get; set; }

        /// <summary>
        /// 由于标签数量限制未设置成功的标签数
        /// </summary>
        /// <value>由于标签数量限制未设置成功的标签数</value>
        [DataMember(Name="unsettagnum", EmitDefaultValue=false)]
        public long? Unsettagnum { get; set; }

        /// <summary>
        /// 未设置成功的标签数组
        /// </summary>
        /// <value>未设置成功的标签数组</value>
        [DataMember(Name="unsettags", EmitDefaultValue=false)]
        public List<string> Unsettags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileAddtagsRes {\n");
            sb.Append("  TagMaxNum: ").Append(TagMaxNum).Append("\n");
            sb.Append("  Unsettagnum: ").Append(Unsettagnum).Append("\n");
            sb.Append("  Unsettags: ").Append(Unsettags).Append("\n");
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
            return this.Equals(input as FileAddtagsRes);
        }

        /// <summary>
        /// Returns true if FileAddtagsRes instances are equal
        /// </summary>
        /// <param name="input">Instance of FileAddtagsRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileAddtagsRes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TagMaxNum == input.TagMaxNum ||
                    (this.TagMaxNum != null &&
                    this.TagMaxNum.Equals(input.TagMaxNum))
                ) && 
                (
                    this.Unsettagnum == input.Unsettagnum ||
                    (this.Unsettagnum != null &&
                    this.Unsettagnum.Equals(input.Unsettagnum))
                ) && 
                (
                    this.Unsettags == input.Unsettags ||
                    this.Unsettags != null &&
                    input.Unsettags != null &&
                    this.Unsettags.SequenceEqual(input.Unsettags)
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
                if (this.TagMaxNum != null)
                    hashCode = hashCode * 59 + this.TagMaxNum.GetHashCode();
                if (this.Unsettagnum != null)
                    hashCode = hashCode * 59 + this.Unsettagnum.GetHashCode();
                if (this.Unsettags != null)
                    hashCode = hashCode * 59 + this.Unsettags.GetHashCode();
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
