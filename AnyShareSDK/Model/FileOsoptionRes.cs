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
    /// FileOsoptionRes
    /// </summary>
    [DataContract]
    public partial class FileOsoptionRes :  IEquatable<FileOsoptionRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileOsoptionRes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileOsoptionRes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileOsoptionRes" /> class.
        /// </summary>
        /// <param name="partminsize">大文件分片上传，除最后一块外，其它分片的最小值；当partminsize小于等于4M时，可按照4M分块；当partminsize大于4M时，分块的大小必须大于等于partminsize。 (required).</param>
        /// <param name="partmaxsize">大文件分片上传，除最后一块外，其它分片的最大值 (required).</param>
        /// <param name="partmaxnum">大文件分片上传，最大的分片数量 (required).</param>
        public FileOsoptionRes(long? partminsize = default(long?), long? partmaxsize = default(long?), long? partmaxnum = default(long?))
        {
            this.Partminsize = partminsize;
            this.Partmaxsize = partmaxsize;
            this.Partmaxnum = partmaxnum;
        }
        
        /// <summary>
        /// 大文件分片上传，除最后一块外，其它分片的最小值；当partminsize小于等于4M时，可按照4M分块；当partminsize大于4M时，分块的大小必须大于等于partminsize。
        /// </summary>
        /// <value>大文件分片上传，除最后一块外，其它分片的最小值；当partminsize小于等于4M时，可按照4M分块；当partminsize大于4M时，分块的大小必须大于等于partminsize。</value>
        [DataMember(Name="partminsize", EmitDefaultValue=false)]
        public long? Partminsize { get; set; }

        /// <summary>
        /// 大文件分片上传，除最后一块外，其它分片的最大值
        /// </summary>
        /// <value>大文件分片上传，除最后一块外，其它分片的最大值</value>
        [DataMember(Name="partmaxsize", EmitDefaultValue=false)]
        public long? Partmaxsize { get; set; }

        /// <summary>
        /// 大文件分片上传，最大的分片数量
        /// </summary>
        /// <value>大文件分片上传，最大的分片数量</value>
        [DataMember(Name="partmaxnum", EmitDefaultValue=false)]
        public long? Partmaxnum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileOsoptionRes {\n");
            sb.Append("  Partminsize: ").Append(Partminsize).Append("\n");
            sb.Append("  Partmaxsize: ").Append(Partmaxsize).Append("\n");
            sb.Append("  Partmaxnum: ").Append(Partmaxnum).Append("\n");
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
            return this.Equals(input as FileOsoptionRes);
        }

        /// <summary>
        /// Returns true if FileOsoptionRes instances are equal
        /// </summary>
        /// <param name="input">Instance of FileOsoptionRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileOsoptionRes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Partminsize == input.Partminsize ||
                    (this.Partminsize != null &&
                    this.Partminsize.Equals(input.Partminsize))
                ) && 
                (
                    this.Partmaxsize == input.Partmaxsize ||
                    (this.Partmaxsize != null &&
                    this.Partmaxsize.Equals(input.Partmaxsize))
                ) && 
                (
                    this.Partmaxnum == input.Partmaxnum ||
                    (this.Partmaxnum != null &&
                    this.Partmaxnum.Equals(input.Partmaxnum))
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
                if (this.Partminsize != null)
                    hashCode = hashCode * 59 + this.Partminsize.GetHashCode();
                if (this.Partmaxsize != null)
                    hashCode = hashCode * 59 + this.Partmaxsize.GetHashCode();
                if (this.Partmaxnum != null)
                    hashCode = hashCode * 59 + this.Partmaxnum.GetHashCode();
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